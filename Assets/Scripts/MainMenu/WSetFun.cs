using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
public class WSetFun : MonoBehaviour
{
    public GameObject ResolutionButton;
    public Camera Camera;
    public PostProcessVolume CameraVolume;
    public AudioSource BGMSource;
    public AudioSource SFXSource;

    public void SetGraphicsQuality(int GraphicsIndex)
    {
        PlayerPrefs.SetInt("GraphicsQuality", GraphicsIndex);
        QualitySettings.SetQualityLevel(GraphicsIndex);
    }

    public void SetFramerate(int Frameratecase)
    {
        if (Frameratecase == 0)
        {
            Framerate(30);
        }
        else if (Frameratecase == 1)
        {
            Framerate(45);
        }
        else if (Frameratecase == 2)
        {
            Framerate(60);
        }
        else if (Frameratecase == 3)
        {
            Application.targetFrameRate = -1;
        }
    }
    public void AntiAliasing(int index)
    {
        // idk
        PlayerPrefs.SetInt("AntiAliasingMode", index);
        if (index == 0)
            QualitySettings.antiAliasing = 0;
        if (index == 1)
            QualitySettings.antiAliasing = 1;
        if (index == 2)
            QualitySettings.antiAliasing = 2;
        if (index == 3)
            QualitySettings.antiAliasing = 3;
    }
    private void Framerate(int framerate)
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = framerate;
    }
    public void SetBGMVolume(float vol)
    {
        if (BGMSource)
        {
            PlayerPrefs.SetFloat("BGMVolume", vol);
            BGMSource.volume = vol;
        }
    }
    public void SetSFXVolume(float vol)
    {
        if (SFXSource)
        {
            PlayerPrefs.SetFloat("SFXVolume", vol);
            SFXSource.volume = vol;
        }
    }
    void Start()
    {
        if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.WebGLPlayer && ResolutionButton)
        {
            ResolutionButton.SetActive(false);
        }
    }
}
