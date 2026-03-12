using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VolumeChanger : MonoBehaviour
{
    public AudioSource music;
    public AudioListener audioListener;
    public float currentVolume;
    public Scrollbar volumeScrollbar;

    private void Start()
    {
        music = gameObject.GetComponent<AudioSource>();

        volumeScrollbar = GameObject.Find("VolumeScrollbar").GetComponent<Scrollbar>();

        if (SceneManager.GetActiveScene().buildIndex == 1 || SceneManager.GetActiveScene().buildIndex == 0 || SceneManager.GetActiveScene().buildIndex == 4)
        {
            music = GameObject.Find("BGMusic_Player").GetComponent<AudioSource>();
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
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            audioListener = GameObject.Find("AudioPlayer").GetComponent<AudioListener>();

        }

    }

    // This method is called when the Scrollbar's value changes
    public void ChangeVolume(float sliderValue)
    {
        if (SceneManager.GetActiveScene().buildIndex == 1 || SceneManager.GetActiveScene().buildIndex == 0 || SceneManager.GetActiveScene().buildIndex == 4)
        {
            music.volume = sliderValue;
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            ChangeListenerVolume(sliderValue);
        }
    }

    public void ChangeListenerVolume(float volumeValue)
    {
        AudioListener.volume = Mathf.Clamp01(volumeValue);
    }

}
