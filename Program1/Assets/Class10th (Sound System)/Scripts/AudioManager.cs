using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] Toggle toggle;

    public void SetPause()
    {
        if(toggle.isOn)
        {
            audioSource.UnPause();
        }
        else
        {
            audioSource.Pause();
        }
    }
}
