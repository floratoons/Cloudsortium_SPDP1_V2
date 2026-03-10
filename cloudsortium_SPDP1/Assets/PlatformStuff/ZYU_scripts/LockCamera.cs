using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCamera : MonoBehaviour
{
    public CameraFollow cameraScript;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("CameraLock"))
        {
            cameraScript.enabled = false;
            cameraScript.GetComponent<Camera>().orthographicSize = 9f;
            Debug.Log("locked");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
        if (collision.CompareTag("CameraLock"))
        {
            cameraScript.enabled = true;
            cameraScript.GetComponent<Camera>().orthographicSize = 5f;
            Debug.Log("unlocked");
        }
    }
    

  
}

