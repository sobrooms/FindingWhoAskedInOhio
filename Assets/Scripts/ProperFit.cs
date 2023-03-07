using UnityEngine;
using UnityEngine.UI;
public class ProperFit : MonoBehaviour
{
    public Canvas[] ItemsToFit;
    private void Update()
    {
        foreach (Canvas item in ItemsToFit)
        {
            item.GetComponent<CanvasScaler>().uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            item.GetComponent<CanvasScaler>().referenceResolution = new Vector2(Screen.width, Screen.height);
        }
    }
}