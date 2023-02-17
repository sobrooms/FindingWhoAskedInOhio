using UnityEngine;

public class FPSLimiter : MonoBehaviour {
    // set the game's target framerate using a dropdown value 
    public void LimitFPS(int index)
    {
        if (index == 1)
        {
            QualitySettings.vSyncCount = 2;
            Application.targetFrameRate = 30;
        }
        if (index == 2)
        {
            QualitySettings.vSyncCount = 2;
            Application.targetFrameRate = 45;
        }
        if (index == 3)
        {
            QualitySettings.vSyncCount = 1;
            Application.targetFrameRate = 60;
        }
        if (index == 4)
        {
            QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = 10;
        }
    }
}