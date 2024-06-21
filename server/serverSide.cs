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
        UnityEngine.Debug.Log("Sussy baka");

        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            What();
        }

	SceneManager.activeSceneChanged += delegate(Scene oldScene, Scene scene)
	{
            if (scene.name == "MainMenu")
            {
                What();
            }
	};
    }

    internal void What()
    {
	PlayerParticles playerp = GameObject.Find("PlayerParticles").GetComponent<PlayerParticles>();
        playerp.velocity.max = 100f;
	playerp.pool.poolSize = 100;
	Time.timeScale = 4.0f;
    }
}
