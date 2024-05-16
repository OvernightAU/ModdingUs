using System;
using UnityEngine;
using TMPro;
using HarmonyLib;
// Harmful usings are blocked, dont even try lol.

public class DynamicCode
{
    private Harmony harmony;
    
    public void Execute()
    {
        GameObject.Find("VersionShower").GetComponent<TextMeshPro>().text += "<color=blue><size=75%> Runtime code loaded!";
        UnityEngine.Debug.Log("Sussy baka");
        harmony.PatchAll();
    }

    [HarmonyPatch(typeof(PlayerControl), "FixedUpdate")]
    public static void PlayerControlUpdate(PlayerControl __instance)
    {
        __instance.nameText.Text = "TEST " + Time.realtimeSinceStartup;
    }
}
