using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private PlayerMovement stopMoving;

    public GameObject timesUp;
    public AudioSource buzzer;
    public AudioSource threeRemaining;

   
    private bool cdPlayed = false;
    private bool buzzerPlayed = false;

    public float currentTime = 10f;
    private bool active = true;




    private void Update()
    {
        if (!active)
            return;

        currentTime -= Time.deltaTime;

        UpdateTimerUI();

        if(currentTime <= 0)
        {
            StopTimer();  
        }

     
    }

    public void StopTimer()
    {
        active = false;
        currentTime = 0;
        UpdateTimerUI();
    }

    private void UpdateTimerUI()
    {
        if (currentTime > 0 && currentTime < 4 && cdPlayed == false)
        {
            timeText.color = Color.yellow;
            ThreeSeconds();
            cdPlayed = true;

        }
        else if (currentTime <1 && buzzerPlayed == false)
        {
            timeText.color = Color.red;
            timesUp.gameObject.SetActive(true);
            stopMoving.StopMoving();
            Buzzer();
            buzzerPlayed = true;
            Debug.Log("TIMES UP BOI");
            StartCoroutine(Wait());

        }

        TimeSpan t = TimeSpan.FromSeconds(currentTime);
        timeText.text = t.ToString(@"mm\:ss");
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(3);
    }

    void Buzzer()
    {
        buzzer.Play();
    }

    void ThreeSeconds()
    {
        threeRemaining.Play();
        
    }
}
