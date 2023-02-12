using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WSetFun : MonoBehaviour
{
    public GameObject ResolutionButton;
    public void SetGraphicsQuality(int GraphicsIndex)
    {
        QualitySettings.SetQualityLevel(GraphicsIndex);
    }

    void Start()
    {
        if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.WebGLPlayer)
        {
            ResolutionButton.SetActive(false);
        }
    }
}
