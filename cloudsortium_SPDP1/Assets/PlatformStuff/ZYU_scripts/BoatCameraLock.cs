using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatCameraLock : MonoBehaviour
{
    public CameraFollow cameraScript;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            
            cameraScript.GetComponent<Camera>().orthographicSize = 7f;

            Debug.Log("be big");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            
            cameraScript.GetComponent<Camera>().orthographicSize = 5f;
            Debug.Log("be small");
        }
    }
}
