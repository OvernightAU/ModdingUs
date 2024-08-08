using System;
using UnityEngine;
using TMPro;
using HarmonyLib;
using UnityEngine.SceneManagement;
// Harmful usings are blocked, dont even try lol.
// Harmony is not recommended for several compatibility reasons, so you should make event-based things instead of using harmony

public class DynamicCode
{    
    public void Execute()
    {
        Debug.Log("Online Asset Preloader Initialized.");

        SceneManager.activeSceneChanged += delegate(Scene oldScene, Scene scene)
	    {
            if (scene.name == "MainMenu")
            {
                ExecuteMainMenu();
            }
	    };
    }

    public void ExecuteMainMenu()
    {
        Debug.Log("Hooked up main menu loaded.");
    }
}
