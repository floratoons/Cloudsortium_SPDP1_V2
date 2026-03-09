using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClip_Holder : MonoBehaviour
{
    public static AudioClip_Holder Instance;
    
    [SerializeField]
    public List<AudioClip> audioClips = new List<AudioClip>();

    public AudioClip[] combinedAudioPlay;

    private AudioSource audioSource; // Reference to the AudioSource component

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("AudioSource component not found! Please attach one.");
        }
    }

    // Example method to play a random sound from the array
    public void PlayRandomClip()
    {
        if (combinedAudioPlay.Length > 0 && audioSource != null)
        {
            // Select a random index
            int randomIndex = Random.Range(0, combinedAudioPlay.Length);
            // Play the selected clip
            audioSource.PlayOneShot(audioClips[randomIndex]);
        }
    }
}
