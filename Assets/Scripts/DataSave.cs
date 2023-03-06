using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DataSave : MonoBehaviour
{
    // remember settings
    public Toggle FPSToggle;
    public TMP_Dropdown TargFPSDropdown;
    public TMP_Dropdown GraphicsDropdown;
    public TMP_Dropdown AntiAliasingModeDropdown;
    public TMP_Dropdown ResolutionDropdown;
    public Toggle FullScreenToggle;

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

        if (AntiAliasingModeDropdown)
            AntiAliasingModeDropdown.value = PlayerPrefs.GetInt("AntiAliasingMode");
        if (ResolutionDropdown)
            ResolutionDropdown.value = PlayerPrefs.GetInt("ResolutionIndex");
        if (FullScreenToggle)
        {
            if (PlayerPrefs.GetInt("FullScreenToggleValue") == 1)
            {
                FullScreenToggle.isOn = true;
            }
            else if (PlayerPrefs.GetInt("FullScreenToggleValue") == 0)
            {
                FullScreenToggle.isOn = false;
            } 
        }
    }
}
