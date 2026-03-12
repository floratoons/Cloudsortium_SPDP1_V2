using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClip_Holder : MonoBehaviour
{
    public static AudioClip_Holder Instance;
    
    [SerializeField]

    public AudioClip[] combinedAudioPlay;

    private AudioSource audioSource; // Reference to the AudioSource component

    void Start()
    {
        /*
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("AudioSource component not found! Please attach one.");
        }*/
    }

    private void Update()
    {
        
    }

    
}
