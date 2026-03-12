using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximitySound : MonoBehaviour
{

    public AudioSource audioSource;
    public Transform player;
    public float maxDistance = 5f;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
      float distance = Vector3.Distance(player.position, transform.position);
        float volume = Mathf.Clamp01(1 - (distance / maxDistance));
        audioSource.volume = volume;
    }
}
