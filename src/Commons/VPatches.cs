using HarmonyLib;

namespace AsLimc.Commons {
    internal class VPatches {
        [HarmonyPatch(typeof(Db), "Initialize")]
        internal class Db_Initialize {
            private static void Postfix(Db __instance) {
                VLib.OnDbInitializeEnd(__instance);
            }
        }
    }
}