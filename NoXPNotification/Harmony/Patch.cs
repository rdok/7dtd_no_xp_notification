using System;
using HarmonyLib;

namespace NoXPNotification.Harmony
{
    [HarmonyPatch(typeof(XUiC_CollectedItemList), nameof(XUiC_CollectedItemList.AddIconNotification))]
    public static class Patch
    {
        private static readonly ILogger Logger = new Logger();

        public static bool Prefix(string iconNotifier)
        {
            Logger.Info($"AddIconNotification: {iconNotifier}");

            return iconNotifier != "ui_game_symbol_xp";
        }
    }
}