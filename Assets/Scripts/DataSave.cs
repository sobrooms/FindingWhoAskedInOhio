using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DataSave : MonoBehaviour
{
    // remember settings
    public Toggle FPSToggle;
    public TMP_Dropdown TargFPSDropdown;
    public TMP_Dropdown GraphicsDropdown;

    // only run on scene open
    private void Start()
    {
        if (FPSToggle)
        {
            // FPS COUNTER TOGGLE
            if (PlayerPrefs.GetInt("FPSCounterToggled") == 1)
            {
                FPSToggle.isOn = true;
            }
            else if (PlayerPrefs.GetInt("FPSCounterToggled") == 0)
            {
                FPSToggle.isOn = false;
            }
        }
        // TARGET FPS DROPDOWN
        if (TargFPSDropdown)
            TargFPSDropdown.value = PlayerPrefs.GetInt("TargetFPSDropdownCurrentValue");

        if (GraphicsDropdown)
            GraphicsDropdown.value = PlayerPrefs.GetInt("GraphicsQuality");

        if (Application.platform == RuntimePlatform.WindowsEditor && Debug.isDebugBuild)
        {
            Debug.LogFormat(PlayerPrefs.GetInt("TargetFPSDropdownCurrentValue").ToString(), PlayerPrefs.GetInt("FPSCounterToggled").ToString());
        }
        else if (Debug.isDebugBuild && Application.platform != RuntimePlatform.WindowsEditor)
        {
            Debug.LogErrorFormat(PlayerPrefs.GetInt("TargetFPSDropdownCurrentValue").ToString(), PlayerPrefs.GetInt("FPSCounterToggled").ToString());
        }
    }
}
