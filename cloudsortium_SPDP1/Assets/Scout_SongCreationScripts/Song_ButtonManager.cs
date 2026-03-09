using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Song_ButtonManager : MonoBehaviour
{
    public GameObject finishedCanvas;

    private void Start()
    {
        
    }

    public void Replay()
    {
        // get all audio
        // put it back to the beginning?
        // replay
    }

    public void PlayPause()
    {
        // plays or pauses depending on whether it's playing or paused
    }

    public void Stop()
    {
        // stops and moves it back to beginning, doesn't replay
    }

    public void FinishedSongCreator()
    {
        // checks if the song is right
        // adds popup, plays the song one more time
        // canvas popup to go back to the HQ scene (1)
    }

    public void PlayPlacedSong()
    {
        // gets the audio clip placed on just that box
        // plays that audio clip once
    }


}
