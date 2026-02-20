using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CustomizationButtonManager : MonoBehaviour
{
    public List<GameObject> custSprites = new List<GameObject>();
    private int custSpriteIndex = 0;
    private EventSystem eventSystem;

    void Start()
    {
        eventSystem = EventSystem.current;
    }

    public void LeftCycle()
    {
        NavigateLeft();
    }

    public void RightCycle()
    {
        NavigateRight();
    }

    void Update()
    {

    }

    private void NavigateRight()
    {
        if (custSprites.Count == 0) return;

        custSpriteIndex--;
        if (custSpriteIndex < 0)
        {
            custSpriteIndex = custSprites.Count - 1; // Loop to the end of the list
        }
        eventSystem.SetSelectedGameObject(custSprites[custSpriteIndex].gameObject);
        
    }

    private void NavigateLeft()
    {
        if (custSprites.Count == 0) return;

        custSpriteIndex++;
        if (custSpriteIndex >= custSprites.Count)
        {
            custSpriteIndex = 0; // Loop to the start of the list
        }
        eventSystem.SetSelectedGameObject(custSprites[custSpriteIndex].gameObject);
    }
}
