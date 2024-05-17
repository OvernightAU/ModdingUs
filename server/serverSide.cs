using System;
using UnityEngine;
using TMPro;
using HarmonyLib;
// Harmful usings are blocked, dont even try lol.
// Harmony is not recommended for several compatibility reasons, so you should make event-based things instead of using harmony

public class DynamicCode
{
    private static bool already = false;
    
    public void Execute()
    {
        if (already) return;
        already = true;
        GameObject.Find("VersionShower").GetComponent<TextMeshPro>().text += "<color=blue><size=75%> GITHUB LOADED!";
        UnityEngine.Debug.Log("Sussy baka");
    }
}
