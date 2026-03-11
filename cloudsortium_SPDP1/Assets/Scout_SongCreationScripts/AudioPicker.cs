using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPicker : MonoBehaviour
{
    public List<GameObject> slotList = new List<GameObject>();
    public GameObject audioVis;

    private void Start()
    {
        audioVis = GameObject.Find("AudioVis");
    }

    public void placementCheck(string placedDropString)
    {
        for (int i = 0; i < slotList.Count; i++)
        {

        }
    }


}
