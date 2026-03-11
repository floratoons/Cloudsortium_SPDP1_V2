using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipboat : MonoBehaviour
{
   // private SpriteRenderer spriteRenderer;


    void Start()
    {
      //  spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Boat"))
        {

            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
