using UnityEngine;

public class DebugChecker : MonoBehaviour
{
    public GameObject MainMenuDebugText;
    void Update()
    {
        if (Debug.isDebugBuild)
        {
            MainMenuDebugText.SetActive(true);
        }
    }
}