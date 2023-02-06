using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menutil : MonoBehaviour
{
    public GameObject SettingsScreen;
    public GameObject MainScreen;
    public void ShowSettingsScreen()
    {
        MainScreen.SetActive(false);
        // SettingsScreen = GameObject.Find("Settings UI").GetComponent<Canvas>();

        SettingsScreen.SetActive(true);
    }
    public void ReturnToMainMenu()
    {
        SettingsScreen.SetActive(false);
        MainScreen.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.F10))
        {
            Screen.SetResolution(1270, 1222, false);
        }
    }
}
