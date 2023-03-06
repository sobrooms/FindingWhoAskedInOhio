using UnityEngine;

public class DebugChecker : MonoBehaviour
{
    public GameObject MainMenuDebugText;
    void Update()
    {
        if (Debug.isDebugBuild)
            MainMenuDebugText.GetComponent<TMPro.TMP_Text>().text = "<align=center>Finding Who Asked In Ohio - Development";
        else 
            MainMenuDebugText.GetComponent<TMPro.TMP_Text>().text = "<align=center>Finding Who Asked In Ohio";
    }
}