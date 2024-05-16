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
        if (harmony != null) return;
        harmony = new Harmony("com.example.dynamiccode");
        GameObject.Find("VersionShower").GetComponent<TextMeshPro>().text += "<color=blue><size=75%> Runtime code v2 loaded!";
        UnityEngine.Debug.Log("Sussy baka");
        PatchPlayerControlUpdate();
    }

    public void PlayerControlUpdatePostfix(PlayerControl __instance)
    {
        __instance.nameText.Text = "TEST " + Time.realtimeSinceStartup;
    }

    private void PatchPlayerControlUpdate()
    {
        var original = AccessTools.Method(typeof(PlayerControl), "FixedUpdate");
        var postfix = new HarmonyMethod(typeof(DynamicCode), "PlayerControlUpdatePostfix");

        harmony.Patch(original, postfix: postfix);
    }
}
