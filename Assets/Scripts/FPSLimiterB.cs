using UnityEngine;
using System;

public class FPSLimiterB : MonoBehaviour
{

    private int Framerate;

    void Start()
    {
        Application.targetFrameRate = -1;
        QualitySettings.vSyncCount = 0;
    }

    void Update()
    {
        long lastTicks = DateTime.Now.Ticks;
        long currentTicks = lastTicks;
        float delay = 1f / Framerate;
        float elapsedTime;

        if (Framerate <= 0)
            return;

        while (true)
        {
            currentTicks = DateTime.Now.Ticks;
            elapsedTime = (float)TimeSpan.FromTicks(currentTicks - lastTicks).TotalSeconds;
            if (elapsedTime >= delay)
            {
                break;
            }
        }
    }

    public void SetFramerate(int index)
    {
        PlayerPrefs.SetInt("TargetFPSDropdownCurrentValue", index);
        if (index == 1)
        {
            Framerate = 30;
        }
        if (index == 2)
        {
            Framerate = 45;
        }
        if (index == 3)
        {
            Framerate = 60;
        }
        if (index == 4)
        {
            Framerate = (int)1000000000;
        }
    }
}