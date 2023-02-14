using UnityEngine;

public class MobileChecker : MonoBehaviour {
    public GameObject MobileUIControls;

    void Start() {
        if (Application.platform == RuntimePlatform.Android)
        {
            MobileUIControls.SetActive(true);
        }
    }
}