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
    // Start is called before the first frame update
    void Start()
    {
        GameIsPaused = false;
        SettingsIsOpen = false;    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody CameraO = CameraObject.GetComponent<Rigidbody>();
        Debug.Log(CameraO);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                ResumeGame();
            }
            else if (!GameIsPaused && !SettingsIsOpen)
            {
                UISettings?.SetActive(true);
                Time.timeScale = 0f * Time.deltaTime;
                GameIsPaused = true;
                CameraO.velocity = Vector3.zero;
                CameraO.angularVelocity = Vector3.zero;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftControl) && GameIsPaused)
        {
            CursorU(false);
        }
        if (Input.GetKeyDown(KeyCode.RightControl) || Input.GetMouseButtonDown(1) && !GameIsPaused)
        {
            CursorU(true);
        }
    }

    public void ResumeGame()
    {
        Rigidbody CameraO = CameraObject.GetComponent<Rigidbody>();
        UISettings?.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        CursorU(true);
        CameraO.velocity = Vector3.one;
        CameraO.angularVelocity = Vector3.one;
    }
    public void ShowSettings()
    {
        RelSettings.SetActive(true);
        UISettings.SetActive(false);
        SettingsIsOpen = true;
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
