using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class AdvancedLevelManager : MonoBehaviour
{
    public GameObject loadingPanel;
    public Slider loadingBar;
    public TMP_Text loadingText;
    public GameObject SettingsUI;
    public GameObject MainUI;
    public void LoadLevel(string levelName)
    {
        StartCoroutine(LoadSceneAsync(levelName));
    }

    IEnumerator LoadSceneAsync(string levelName)
    {
        AsyncOperation op = SceneManager.LoadSceneAsync(levelName);

        while (!op.isDone)
        {
            float progress = Mathf.Clamp01(op.progress / .9f);
            //Debug.Log(op.progress);
            loadingBar.value = progress;
            loadingText.text = "<align=center>" + progress * 100f + "%";

            yield return null;
        }
    }

    public void HideMe(GameObject obj)
    {
        obj.SetActive(false);
    }
}