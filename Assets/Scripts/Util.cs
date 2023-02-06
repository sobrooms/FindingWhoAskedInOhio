using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Reflection;

public class Util : MonoBehaviour
{
    bool LogOpened;
    public void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Debug.LogError("Locked cursor");
    }
    public void CursorVis(bool isVisible)
    {
        Debug.LogError("Set cursor vis bool: " + isVisible);
        Cursor.visible = isVisible;
    }
    void Update()
    {
        var ThisScene = SceneManager.GetActiveScene();
        if (Input.GetKeyDown(KeyCode.F1))
        {
            Debug.LogError("Opened dev log");
            Debug.ClearDeveloperConsole();
            LogOpened = true;
        }
        if (ThisScene.ToString().EndsWith("Scene") && Input.GetKeyDown(KeyCode.Escape))
        {
            if (LogOpened)
            {
                Debug.Log("Opened settings component");
            }
        }
    }
}
