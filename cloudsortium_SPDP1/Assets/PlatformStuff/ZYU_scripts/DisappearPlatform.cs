using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappearPlatform : MonoBehaviour
{
    public float disappearTime = 2.0f;
    public bool playerOnPlatform = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerOnPlatform)
        {
            disappearTime -= Time.deltaTime;
            if (disappearTime < 0)
            {

                gameObject.SetActive(false);
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerOnPlatform = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerOnPlatform = false;
        }
    }

    public void ResetPlatform()
    {
        gameObject.SetActive(true);
        disappearTime = 2f;
        playerOnPlatform = false;
    }
}
