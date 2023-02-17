using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
public class WSetFun : MonoBehaviour
{
    public GameObject ResolutionButton;
    public GameObject Camera;
    public void SetGraphicsQuality(int GraphicsIndex)
    {
        PlayerPrefs.SetInt("GraphicsQuality", GraphicsIndex);
        QualitySettings.SetQualityLevel(GraphicsIndex);
    }

    public void SetFramerate(int Frameratecase)
    {
        if (Frameratecase == 1)
        {
            Framerate(30);
        }
        else if (Frameratecase == 2)
        {
            Framerate(45);
        }
        else if (Frameratecase == 3)
        {
            Framerate(60);
        }
        else if (Frameratecase == 4)
        {
            Application.targetFrameRate = -1;
        }
    }

    private void Framerate(int framerate)
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = framerate;
    }
    public void SetPostProcessing()
    {
        
    }
    void Start()
    {
        if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.WebGLPlayer && ResolutionButton)
        {
            ResolutionButton.SetActive(false);
        }
    }
}
