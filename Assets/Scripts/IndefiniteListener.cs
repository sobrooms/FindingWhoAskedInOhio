using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class IndefiniteListener : MonoBehaviour
{
    public GameObject UISettings;
    public GameObject RelSettings;
    private bool GameIsPaused;
    private bool SettingsIsOpen;
    public GameObject CameraObject;
    private Vector3 defaultVelocity;
    // Start is called before the first frame update
    void Start()
    {
        GameIsPaused = false;
        SettingsIsOpen = false;
        defaultVelocity = CameraObject.GetComponent<Camera>().velocity;
    }

    // Update is called once per frame
    void Update()
    {
        //Rigidbody CameraO = CameraObject.GetComponent<Rigidbody>();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                ResumeGame();
            }
            else if (!GameIsPaused && !SettingsIsOpen)
            {
                PauseGame();
            }
        }
        // if (Input.GetKeyDown(KeyCode.LeftControl))
        if (Input.GetKey(KeyCode.LeftControl))
        {
            CursorU(false);
        }
        else
        {
            CursorU(true);
        }
        if (Input.GetKeyDown(KeyCode.RightControl) || Input.GetMouseButtonDown(1) && !GameIsPaused)
        {
            CursorU(true);
        }
        if (Input.GetKeyDown(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.Semicolon) && Debug.isDebugBuild)
        {
            Screen.SetResolution(1270, 1270, false);
        }
    }

    public void ResumeGame()
    {
        //Rigidbody CameraO = CameraObject.GetComponent<Rigidbody>();
        UISettings?.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        CursorU(false);
        //CameraObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        if (SettingsIsOpen)
        {
            RelSettings.SetActive(false);
            SettingsIsOpen = false;
        }
    }
    public void ShowSettings()
    {
        RelSettings.SetActive(true);
        UISettings.SetActive(false);
        SettingsIsOpen = true;
        CursorU(false);
    }
    public void BackToPause()
    {
        if (GameIsPaused && SettingsIsOpen)
        {
            RelSettings.SetActive(false);
            UISettings.SetActive(true);
            SettingsIsOpen = false;
        }
    }

    public void PauseGame()
    {
        UISettings?.SetActive(true);
        Time.timeScale = 0f * Time.deltaTime;
        GameIsPaused = true;
        //CameraObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        CursorU(false);
    }
    public void CursorU(bool LockOrNo)
    {
        if (LockOrNo)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
