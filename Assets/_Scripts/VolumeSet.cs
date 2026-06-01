using UnityEngine;
using UnityEngine.UI;


public class VolumeSet : MonoBehaviour
{
    public Slider VolumeSlider;
    public float soundvolume;

 
    public void changeVolume(float newVolume)
    {

        soundvolume = VolumeSlider.value * 10f;
        PlayerPrefs.SetFloat("volume", soundvolume);
        AudioListener.volume = PlayerPrefs.GetFloat("volume");
    }
}