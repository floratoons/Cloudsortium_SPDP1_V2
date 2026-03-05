using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacedMelodrop_Reader : MonoBehaviour
{
    public List<GameObject> placementBoxes = new List<GameObject>();
    public GameObject placedin1;
    public GameObject placedin2;
    public GameObject placedin3;
    public GameObject placedin4;

    void Start()
    {
        
    }

    void Update()
    {
        placedin1 = placementBoxes[0];
        placedin2 = placementBoxes[1];
        placedin3 = placementBoxes[2];
        placedin4 = placementBoxes[3];
    }
}
