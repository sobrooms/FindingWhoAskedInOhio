using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WSetFun : MonoBehaviour
{
    public void SetGraphicsQuality(int GraphicsIndex)
    {
        QualitySettings.SetQualityLevel(GraphicsIndex);
    }
}
