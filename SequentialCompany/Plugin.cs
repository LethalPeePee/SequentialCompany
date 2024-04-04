using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace SequentialCompany
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class SequentialCompany : BaseUnityPlugin
    {
        private const string modGUID = "LethalPeePee.SequentialCompany";
        private const string modName = "Sequential Company";
        private const string modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static SequentialCompany Instance;

        internal ManualLogSource mls;
        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("Sequential Company started");

            harmony.PatchAll(typeof(SequentialCompany));
        }
    }
}
