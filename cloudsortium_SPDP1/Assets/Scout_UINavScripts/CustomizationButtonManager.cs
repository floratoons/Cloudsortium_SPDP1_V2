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

    private void Update()
    {
        SetActiveObjectByIndex(custSpriteIndex);
    }

    public void SetActiveObjectByIndex(int activeIndex)
    {
        for (int i = 0; i < custSprites.Count; i++)
        {
            // check if the current indexed obj matches the currently selected obj
            if (i == activeIndex)
            {
                // activate the indexed obj
                custSprites[i].SetActive(true);
            }
            else
            {
                // deactivate all other objs
                custSprites[i].SetActive(false);
            }
        }
    }

    private void NavigateRight()
    {
        if (custSprites.Count == 0) return;

        custSpriteIndex--;

        if (custSpriteIndex < 0)
        {
            custSpriteIndex = custSprites.Count - 1; // Loop to the end of the list
            Debug.Log("current cust sprite is " + custSprites[custSpriteIndex].name);
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
            Debug.Log("current cust sprite is " + custSprites[custSpriteIndex].name);
        }
        eventSystem.SetSelectedGameObject(custSprites[custSpriteIndex].gameObject);
    }
}
