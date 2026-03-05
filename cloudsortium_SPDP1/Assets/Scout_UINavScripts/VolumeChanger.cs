using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeChanger : MonoBehaviour
{
    public AudioSource music;
    public float currentVolume;
    public Scrollbar volumeScrollbar;

    private void Start()
    {
        if (music != null)
        {
            // access the current volume
            currentVolume = music.volume;
            Debug.Log("Current volume is: " + currentVolume);
        }
        else
        {
            Debug.LogError("No AudioSource component");
        }
    }

    // This method is called when the Scrollbar's value changes
    public void ChangeVolume(float sliderValue)
    {
        music.volume = sliderValue;
    }

}
