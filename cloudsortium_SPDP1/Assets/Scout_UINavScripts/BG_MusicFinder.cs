using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BG_MusicFinder : MonoBehaviour
{
    public AudioSource bgMusic;

    private void Start()
    {
        Debug.Log("Getting the bg music");

        if (SceneManager.GetActiveScene().buildIndex == 1 || SceneManager.GetActiveScene().buildIndex == 0 || SceneManager.GetActiveScene().buildIndex == 4)
        {
            GameObject bgmusicholder = GameObject.Find("BGMusic_Player");
            bgMusic = bgmusicholder.GetComponent<AudioSource>();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            bgMusic.Stop();
        }
    }

    private void Update()
    {
        if (gameObject.GetComponent<SimpleSpectrum>().audioSource != bgMusic)
        {
            gameObject.GetComponent<SimpleSpectrum>().audioSource = bgMusic;
        }
    }
}
