using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Song_ButtonManager : MonoBehaviour
{
    public GameObject finishedCanvas;
    public GameObject finalPopup;
    public AudioClip finalSong;
    public AudioSource audioSource;

    private void Start()
    {
        
    }

    public void PlayBox()
    {
        if (gameObject.transform.childCount == 0)
        {
            Debug.Log("Clicked on box" + gameObject.name + "with no melodrop");
        }
        else
        {
            PlayBoxSound();
        }
    }

    void PlayBoxSound()
    {
        Debug.Log("Clicked on box with melodrop");
        AudioSource.PlayClipAtPoint(gameObject.GetComponentInChildren<SoundData>().fruitData.fruitJingle, transform.position);
        Debug.Log("play sound");
    }

    public void Replay()
    {
        // get all audio
        // put it back to the beginning?
        // replay
        Debug.Log("Pressed replay button");
    }

    public void PlayPause()
    {
        // plays or pauses audio depending on whether it's playing or paused
        Debug.Log("Pressed play/pause button");
    }

    public void Stop()
    {
        // stops and moves it back to beginning, doesn't replay
        Debug.Log("Pressed stop button");
    }

    public void FinishedSongCreator()
    {
        // checks if the song is right
        // adds popup, plays the song one more time
        audioSource.PlayOneShot(finalSong, 0.5f);
        finishedCanvas.SetActive(true);
        // canvas popup to go back to the HQ scene (1)
        Debug.Log("Pressed finish button");
    }

    public void finishedYesToggle()
    {
        finalPopup.SetActive(true);
        // play final song one more time
        audioSource.PlayOneShot(finalSong);
        StartCoroutine(WaitAndPrint(12));
    }

    public void finishedNoToggle()
    {
        finishedCanvas.SetActive(false);
    }

    public void PlayPlacedSong()
    {
        // gets the audio clip placed on any boxes
        // plays that audio clip once
        Debug.Log("Pressed play button");
    }

    IEnumerator WaitAndPrint(float waitTime)
    {
        Debug.Log("Coroutine started. Waiting for " + waitTime + " seconds.");
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(4);
        Debug.Log("Wait finished. This message appears after the delay.");
    }
}
