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

        GameObject bgmusicholder = GameObject.Find("BGMusic_Player");
        bgMusic = bgmusicholder.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (gameObject.GetComponent<SimpleSpectrum>().audioSource != bgMusic)
        {
            gameObject.GetComponent<SimpleSpectrum>().audioSource = bgMusic;
        }
    }
}
