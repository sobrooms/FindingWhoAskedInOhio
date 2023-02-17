using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioSource InterfaceSource;
    public AudioClip HoverSFX;
    public AudioClip ClickSFX;
    public void Hover()
    {
        if (HoverSFX)
        {
            InterfaceSource.PlayOneShot(HoverSFX);
        }
    }
    public void Click()
    {
        if (ClickSFX)
        {
            InterfaceSource.PlayOneShot(ClickSFX);
        }
    }
}