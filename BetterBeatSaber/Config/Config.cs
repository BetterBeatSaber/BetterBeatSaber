﻿using System;
using System.Collections.Generic;
using System.IO;

using BetterBeatSaber.Config.Converters;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace BetterBeatSaber.Config;

public abstract class Config<T> where T : Config<T> {

    public static T Instance { get; private set; } = null!;
    
    // ReSharper disable once StaticMemberInGenericType
    public static readonly JsonSerializerSettings SerializerSettings = new() {
        Formatting = Formatting.Indented,
        NullValueHandling = NullValueHandling.Ignore,
        DefaultValueHandling = DefaultValueHandling.Populate,
        TypeNameHandling = TypeNameHandling.Auto,
        Converters = new List<JsonConverter>() {
            new StringEnumConverter(),
            new ColorConverter(),
            new Vector3Converter(),
            new QuaternionConverter()
        },
        ContractResolver = new DefaultContractResolver {
            NamingStrategy = new SnakeCaseNamingStrategy()
        }
    };
    
    [JsonIgnore]
    public string Path { get; private set; }
    
    // ReSharper disable once ConvertToPrimaryConstructor
    protected Config(string name) {
        Instance = (T) this;
        Path = System.IO.Path.Combine(Environment.CurrentDirectory, "UserData", $"{name}.json");
        Load();
    }

    public void Load() {
        if (File.Exists(Path)) {
            JsonConvert.PopulateObject(File.ReadAllText(Path), this, SerializerSettings);
        } else Save();
    }

    public void Save() =>
        File.WriteAllText(Path, JsonConvert.SerializeObject(this, SerializerSettings));

    // Resources.FindObjectsOfTypeAll<MenuTransitionsHelper>().FirstOrDefault()?.RestartGame();
    
}