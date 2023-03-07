using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class SettingsFunctions : MonoBehaviour
{
    // public Dropdown DropdownResolution;
    public TMP_Dropdown DropdownResolution;
    private List<Resolution> FilteredResolutions;
    //int DropdownResolutionValue;
    private Resolution[] resolutions;
    private float currentRefreshrate;
    private int currentResolutionIndex = 0;
    private int fl;
    private int fw;

    void Start()
    {
        /*if (SceneManager.GetActiveScene().name == "Resolution")
        {*/
        if (DropdownResolution && DropdownResolution?.name == "Set resolution")
        {
            resolutions = Screen.resolutions;
            FilteredResolutions = new List<Resolution>();
            DropdownResolution.ClearOptions();
            currentRefreshrate = Screen.currentResolution.refreshRate;

            for (int i = 0; i < resolutions.Length; i++)
            {
                if (resolutions[i].refreshRate == currentRefreshrate)
                {
                    FilteredResolutions.Add(resolutions[i]);
                }
            }
            List<string> options = new List<string>();

            for (int i = 0; i < FilteredResolutions.Count; i++)
            {
                string ResolOption = FilteredResolutions[i].width + "x" + FilteredResolutions[i].height;
                options.Add(ResolOption);

                if (FilteredResolutions[i].width == Screen.width && FilteredResolutions[i].height == Screen.height)
                {
                    currentResolutionIndex = i;
                }
            }
            DropdownResolution.AddOptions(options);
            DropdownResolution.value = currentResolutionIndex;
            DropdownResolution.RefreshShownValue();
            //}
        }
    }
    public void SetWindowResolution(int ResolutionIndex)
    {
        // actual set

        Resolution resolution = FilteredResolutions[ResolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, true);
        fl = resolution.width;
        fw = resolution.height;
        PlayerPrefs.SetInt("ResolutionIndex", ResolutionIndex);
        Debug.Log("Changed window resolution index in PlayerPrefs: " + PlayerPrefs.GetInt("ResolutionIndex"));
    }

    public void SetFullScreen(bool fullScreenMode)
    {
        Screen.fullScreen = fullScreenMode;
        Debug.Log(Screen.fullScreenMode);
        if (fullScreenMode)
            PlayerPrefs.SetInt("FullScreenToggleValue", 1);
        else if (!fullScreenMode)
            PlayerPrefs.SetInt("FullScreenToggleValue", 0);
    }
    /* public void SetWindowResolution()
    {
        DropdownResolutionValue = DropdownResolution.value;
        if (DropdownResolutionValue == 0)
        {
            Screen.SetResolution(Screen.height, Screen.width, true);
        } else if (DropdownResolutionValue == 1) {
            Screen.SetResolution(1920, 1440, false);
        } else if (DropdownResolutionValue == 2) {
            Screen.SetResolution(1920, 1200, false);
        } else if (DropdownResolutionValue == 3) {
            Screen.SetResolution(1920, 1080, false);
        } else if (DropdownResolutionValue == 4) {
            Screen.SetResolution(1768, 992, false);
        } else if (DropdownResolutionValue == 5) {
            Screen.SetResolution(1680, 1050, false);
        } else if (DropdownResolutionValue == 6) {
            Screen.SetResolution(1600, 1200, false);
        } else if (DropdownResolutionValue == 7) {
            Screen.SetResolution(1600, 1024, false);
        } else if (DropdownResolutionValue == 8) {
            Screen.SetResolution(1600, 900, false);
        } else if (DropdownResolutionValue == 4) {
            Screen.SetResolution(1440, 1080, false);
        } else if (DropdownResolutionValue == 4) {
            Screen.SetResolution(1366, 768, false);
        }
    } */

}