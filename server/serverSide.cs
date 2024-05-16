using System;
using UnityEngine;
using TMPro;

public class DynamicCode
{
    public void Execute()
    {
        GameObject.Find(""VersionShower"").GetComponent<TextMeshPro>().text += ""<color=blue> Github!"";
        UnityEngine.Debug.Log(""T"");
    }
}
