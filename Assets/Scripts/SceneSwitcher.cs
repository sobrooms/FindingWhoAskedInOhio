using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void SwitchSceneUsingName(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
    public void SwitchToNextScene()
    {
        var scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene += 1);
    }
    public void SwitchToPreviousScene()
    {
        var scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene -= 1);

    }
}
