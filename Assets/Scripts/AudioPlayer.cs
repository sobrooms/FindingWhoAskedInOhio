using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioSource InterfaceSource;
    public AudioSource BGMAudioSource;
    public AudioClip HoverSFX;
    public AudioClip ClickSFX;
    public AudioClip BGMTrack1;
    public AudioClip BGMTrack3;
    public AudioClip BGMTrack4;
    public AudioClip BGMTrack5;
    public AudioClip BGMTrack6;
    public AudioListener BGMListener;
    private System.Random rn = new System.Random();
    private void Start()
    {
        PlayRandomBGMTrack();
    }
    // button
    public void Hover()
    {
        if (HoverSFX && InterfaceSource)
        {
            InterfaceSource.PlayOneShot(HoverSFX);
        }
    }
    public void Click()
    {
        if (ClickSFX && InterfaceSource)
        {
            InterfaceSource.PlayOneShot(ClickSFX);
        }
    }

    public void PlayRandomBGMTrack()
    {
        if (BGMAudioSource)
        {
            /*int index = Random.Range(0, BGMTracks.Length);
            Debug.Log("Attempted to play bgm track #"+index);
            if (index > BGMTracks.Length)
            {
                Debug.Log("bgm track was larger than bounds");
                index = Random.Range(0, BGMTracks.Length);
            }
            BGMAudioSource.clip = BGMTracks[index];*/
            var n = new[] { BGMTrack1, BGMTrack3, BGMTrack4, BGMTrack5, BGMTrack6 };
            BGMAudioSource.clip = n[rn.Next(0, n.Length)];
            BGMAudioSource.Play();
        }
    }
}