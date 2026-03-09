using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialButtonPlayer : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip soundEffectClip;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayMySoundEffect()
    {
        audioSource.PlayOneShot(soundEffectClip);
    }
}
