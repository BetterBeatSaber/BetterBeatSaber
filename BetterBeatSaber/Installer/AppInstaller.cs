﻿using BetterBeatSaber.Extensions;
using BetterBeatSaber.Interops;

namespace BetterBeatSaber.Installer;

internal sealed class AppInstaller : Zenject.Installer {

    public override void InstallBindings() {
        Container.BindInstance(BetterBeatSaber.Instance).AsSingle();
        Container.BindInterfacesAndSelfTo<Manager.ColorManager>().AsSingle();
        Container.BindInterop<Tweaks55>();
        Container.BindInterop<Interops.SongCore>();
    }
    
}