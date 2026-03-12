using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundData : MonoBehaviour
{
    public FruitData fruitData;
    private AudioSource fruitJingle;

    void Start()
    {
        
    }
    // Start is called before the first frame update
    /*void OnMouseDown()
    {
        Debug.Log("mouse down");
        AudioSource.PlayClipAtPoint(fruitData.fruitJingle, transform.position);
        Debug.Log("play sound");
    }*/
}
