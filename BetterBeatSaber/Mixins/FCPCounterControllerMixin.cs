﻿using BetterBeatSaber.Mixin;
using BetterBeatSaber.Providers;

using TMPro;

namespace BetterBeatSaber.Mixins;

// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Local
// ReSharper disable InconsistentNaming

[MixinPlugin("FCPercentage", "FCPercentage.FCPCounter.FCPCounterController")]
internal static class FCPCounterControllerMixin {

    [MixinMethod(nameof(InitCounterText), MixinAt.Post)]
    private static void InitCounterText(ref TMP_Text ___counterPercentageText) {
        if (BloomFontProvider.Instance != null && BetterBeatSaberConfig.Instance.ColorizeFCPercentage)
            ___counterPercentageText.font = BloomFontProvider.Instance.BloomFont;
    }

}