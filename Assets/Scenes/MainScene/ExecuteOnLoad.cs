using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecuteOnLoad : MonoBehaviour
{
    public GameObject SprintBar;
    private bool GamePaused;
    private void FixedUpdate()
    {
        if (SprintBar)
        {
            if (Input.GetKeyDown(KeyCode.Escape) && !GamePaused)
            {
                GamePaused = true;
                SprintBar.SetActive(false);
            } else if (Input.GetKeyDown(KeyCode.Escape) && GamePaused)
            {
                GamePaused = false;
                SprintBar.SetActive(true);
            }
        }
    }
}
