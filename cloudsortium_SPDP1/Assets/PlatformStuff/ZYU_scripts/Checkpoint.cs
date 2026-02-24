using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private SpriteRenderer checkpointRenderer;
    public Sprite onCheckpoint;
    public Sprite offCheckpoint; //so yk where you'' respawn next time, makes player think
                                 //about future fruit scavenging 

    void Start()
    {
        checkpointRenderer = GetComponent<SpriteRenderer>();

        
        if (PlayerPrefs.GetFloat("X") == transform.position.x && PlayerPrefs.GetFloat("Y") == transform.position.y)
        {
            checkpointRenderer.sprite = onCheckpoint;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            CheckPoint[] allCheckpoints = FindObjectsOfType<CheckPoint>();
            foreach (CheckPoint cp in allCheckpoints)
            {
                cp.GetComponent<SpriteRenderer>().sprite = cp.offCheckpoint;
            }
            
            checkpointRenderer.sprite = onCheckpoint;


            PlayerPrefs.SetFloat("X", transform.position.x);
            PlayerPrefs.SetFloat("Y", transform.position.y);
            PlayerPrefs.Save();

            Debug.Log("new checkpoint saved at: " + transform.position);
        }
    }
}