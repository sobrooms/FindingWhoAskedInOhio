using UnityEngine;
using TMPro;
// get the user's framerate and put it in text
public class FPSCounter : MonoBehaviour
{
    public TMP_Text FramerateText;
    public GameObject FramerateTextCanvas;

    [SerializeField] private float RFRate = 1f;

    private float Timer;

    private void Update()
    {
        if (FramerateText.gameObject.activeInHierarchy)
        {
            if (Time.unscaledTime > Timer)
            {
                int fps = (int)(1f / Time.unscaledDeltaTime);
                FramerateText.text = "FPS: " + fps;
                Timer = Time.unscaledTime + RFRate;
            }
        }
    }

    public void ToggleFramerateCounter(bool togglem)
    {
        if (togglem && FramerateTextCanvas)
        {
            FramerateTextCanvas.SetActive(true);
            PlayerPrefs.SetInt("FPSCounterToggled", 1);
            Debug.Log("FPSCounter toggled: " + PlayerPrefs.GetInt("FPSCounterToggled").ToString());
        }
        else if (!togglem && FramerateTextCanvas)
        {
            FramerateTextCanvas.SetActive(false);
            PlayerPrefs.SetInt("FPSCounterToggled", 0);
            Debug.Log("FPSCounter toggled: " + PlayerPrefs.GetInt("FPSCounterToggled").ToString());
        }
    }
}