using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TABToggle : MonoBehaviour
{
    public Canvas TabCanvas;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Esc key placed");
            TabCanvas.GetComponent<Animator>().enabled = true;
        }
    }
}
