using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private Movement stopMoving;

    public GameObject timesUp;
    public AudioSource buzzer;
    public AudioSource threeRemaining;

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
        if (currentTime > 0 && currentTime < 4)
        {
            timeText.color = Color.yellow;
            threeRemaining.Play();
            Destroy(threeRemaining);
        }
        else if (currentTime <1)
        {
            timeText.color = Color.red;
            buzzer.Play();
            timesUp.gameObject.SetActive(true);
            stopMoving.StopMoving();
            Debug.Log("TIMES UP BOI");
            StartCoroutine(Wait());

        }

        TimeSpan t = TimeSpan.FromSeconds(currentTime);
        timeText.text = t.ToString(@"mm\:ss");
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("1_HQ");
    }

}
