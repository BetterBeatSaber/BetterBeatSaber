﻿namespace BetterBeatSaber.UI.Main;

public partial class MainView {

    #region Game Colorizers

    public bool ColorizeDust {
        get => BetterBeatSaberConfig.Instance.ColorizeDust;
        set => BetterBeatSaberConfig.Instance.ColorizeDust = value;
    }
    
    public bool ColorizeFeet {
        get => BetterBeatSaberConfig.Instance.ColorizeFeet;
        set => BetterBeatSaberConfig.Instance.ColorizeFeet = value;
    }
    
    public bool ColorizePlayersPlace {
        get => BetterBeatSaberConfig.Instance.ColorizePlayersPlace;
        set => BetterBeatSaberConfig.Instance.ColorizePlayersPlace = value;
    }
    
    public bool ColorizeBurnMarks {
        get => BetterBeatSaberConfig.Instance.ColorizeBurnMarks;
        set => BetterBeatSaberConfig.Instance.ColorizeBurnMarks = value;
    }
    
    public bool ColorizeObstacles {
        get => BetterBeatSaberConfig.Instance.ColorizeObstacles;
        set => BetterBeatSaberConfig.Instance.ColorizeObstacles = value;
    }
    
    public bool ColorizeCutParticles {
        get => BetterBeatSaberConfig.Instance.ColorizeCutParticles;
        set => BetterBeatSaberConfig.Instance.ColorizeCutParticles = value;
    }
    
    public bool ColorizeReeSabers {
        get => BetterBeatSaberConfig.Instance.ColorizeReeSabers.CurrentValue;
        set => BetterBeatSaberConfig.Instance.ColorizeReeSabers.SetValue(value);
    }
    
    #endregion

    #region UI Colorizers

    public bool ColorizeButtons {
        get => BetterBeatSaberConfig.Instance.ColorizeButtons;
        set => BetterBeatSaberConfig.Instance.ColorizeButtons = value;
    }
    
    public bool ColorizeMenuButtons {
        get => BetterBeatSaberConfig.Instance.ColorizeMenuButtons;
        set => BetterBeatSaberConfig.Instance.ColorizeMenuButtons = value;
    }
    
    // ReSharper disable once InconsistentNaming
    // ReSharper disable once IdentifierTypo
    public bool ColorizePBOT {
        get => BetterBeatSaberConfig.Instance.ColorizePBOT;
        set => BetterBeatSaberConfig.Instance.ColorizePBOT = value;
    }
    
    // ReSharper disable once InconsistentNaming
    public bool ColorizeFCPercentage {
        get => BetterBeatSaberConfig.Instance.ColorizeFCPercentage;
        set => BetterBeatSaberConfig.Instance.ColorizeFCPercentage = value;
    }
    
    public bool ColorizeFPSCounter {
        get => BetterBeatSaberConfig.Instance.ColorizeFPSCounter;
        set => BetterBeatSaberConfig.Instance.ColorizeFPSCounter = value;
    }

    #endregion

}