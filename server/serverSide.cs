using System;
using UnityEngine;
using TMPro;
using HarmonyLib;
// Harmful usings are blocked, dont even try lol.

public class DynamicCode
{
    private static Harmony harmony;
    
    public void Execute()
    {
        if (harmony != null) return;
        harmony = new Harmony("com.example.dynamiccode");
        GameObject.Find("VersionShower").GetComponent<TextMeshPro>().text += "<color=blue><size=75%> Runtime code v2 loaded!";
        UnityEngine.Debug.Log("Sussy baka");
        PatchPlayerControlUpdate();
    }

    public static void PlayerControlUpdatePostfix(PlayerControl __instance)
    {
        __instance.nameText.Text = "TEST " + Time.realtimeSinceStartup;
    }

    public static void VersionShowerStart(VersionShower __instance)
    {
        __instance.text.Text += "<color=blue><size=75%> Runtime code v2 loaded!";
    }

    private static void PatchPlayerControlUpdate()
    {
        var original = AccessTools.Method(typeof(PlayerControl), "FixedUpdate");
        var postfix = new HarmonyMethod(typeof(DynamicCode), "PlayerControlUpdatePostfix");

        harmony.Patch(original, postfix: postfix);

        var original2 = AccessTools.Method(typeof(VersionShower), "Start");
        var postfix2 = new HarmonyMethod(typeof(DynamicCode), "VersionShowerStart");

        harmony.Patch(original2, postfix: postfix2);
    }
}
