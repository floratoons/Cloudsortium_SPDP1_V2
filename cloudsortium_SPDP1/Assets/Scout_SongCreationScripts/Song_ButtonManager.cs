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
    public AudioListener audioListener;

    public GameObject[] audioBoxes;

    bool paused = false;

    private void Start()
    {
        
    }

    public void PlayBox(int boxID)
    {

        if (audioBoxes[boxID].transform.childCount == 0)
        {
            Debug.Log("Clicked on box #" + boxID + " with no melodrop");
        }
        else
        {
            Debug.Log("Clicked on box with melodrop");
            AudioSource.PlayClipAtPoint(audioBoxes[boxID].GetComponentInChildren<SoundData>().fruitData.fruitJingle, transform.position);
            Debug.Log("play sound");
        }
    }

    public void Replay()
    {
        // get all audio
        // put it back to the beginning?
        // replay
        Debug.Log("Pressed replay button");
    }

    public void PlaySong()
    {
        // plays or pauses audio depending on whether it's playing or paused
        Debug.Log("Pressed play button");
        if (!paused)
        {
            for (int i = 0; i < audioBoxes.Length; i++)
            {
                Debug.Log("Playing " + audioBoxes[i].GetComponentInChildren<SoundData>().fruitData.fruitJingle.name + " soundclip.");
                AudioSource.PlayClipAtPoint(audioBoxes[i].GetComponentInChildren<SoundData>().fruitData.fruitJingle, transform.position);
            }
        }
        else if (paused)
        {
            AudioListener.pause = false;
            Debug.Log("Un-Paused");

            for (int i = 0; i < audioBoxes.Length; i++)
            {
                Debug.Log("Playing " + audioBoxes[i].GetComponentInChildren<SoundData>().fruitData.fruitJingle.name + " soundclip.");
                AudioSource.PlayClipAtPoint(audioBoxes[i].GetComponentInChildren<SoundData>().fruitData.fruitJingle, transform.position);
            }
        }
    }

    public void Pause()
    {
        // plays or pauses audio depending on whether it's playing or paused
        Debug.Log("Pressed pause button");
        if (!paused)
        {
            AudioListener.pause = true;
            Debug.Log("Paused");
        }
        else
        {
            AudioListener.pause = false;
        }
    }

    public void Stop()
    {
        // stops and moves it back to beginning, doesn't replay
        AudioListener.pause = true;
        Debug.Log("Pressed stop button");
    }

    public void FinishedSongCreator()
    {
        AudioListener.pause = true;
        AudioListener.pause = false;
        // checks if the song is right
        // adds popup, plays the song one more time
        audioSource.PlayOneShot(finalSong, 0.25f);
        finishedCanvas.SetActive(true);
        // canvas popup to go back to the HQ scene (1)
        Debug.Log("Pressed finish button");
    }

    public void finishedYesToggle()
    {
        finalPopup.SetActive(true);
        // play final song one more time
        audioSource.PlayOneShot(finalSong);
        StartCoroutine(WaitAndPrint(10));
    }

    public void finishedNoToggle()
    {
        finishedCanvas.SetActive(false);
        AudioListener.pause = true;
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
