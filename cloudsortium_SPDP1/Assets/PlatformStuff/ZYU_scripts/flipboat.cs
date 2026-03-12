using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipboat : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        Debug.Log ("collision registered with " + trigger);
        if (trigger.CompareTag("BoatTrigger"))
        {
            Vector3 newScale = transform.localScale;
            newScale.x *= -1;
            transform.localScale = newScale;
            Debug.Log("it hit the trigger");
        }
    }
}
