﻿using BetterBeatSaber.Mixin;
using BetterBeatSaber.Mixin.Attributes;

namespace BetterBeatSaber.Mixins;

// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Local
// ReSharper disable InconsistentNaming

//[Mixin(typeof(MissedNoteEffectSpawner))]
internal static class MissedNoteEffectSpawnerMixin {

    [MixinMethod(nameof(HandleNoteWasMissed), MixinAt.Pre)]
    private static bool HandleNoteWasMissed() => !BetterBeatSaberConfig.Instance.HideMissTexts;

}