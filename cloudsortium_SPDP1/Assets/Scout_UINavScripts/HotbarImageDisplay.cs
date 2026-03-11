using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HotbarImageDisplay : MonoBehaviour
{
    Image uiImage;

    public SpriteRenderer sourceSpriteRenderer;
    InventoryManager inventoryManagerScript;

    private void Start()
    {
        inventoryManagerScript = GameObject.Find("Inventory_Holder").GetComponent<InventoryManager>();
    }

    void Update()
    {
        uiImage.sprite = GetComponentInChildren<Melodrop>().fruitData.fruitIcon;
        Debug.Log("1. Getting " + uiImage.GetComponentInChildren<Melodrop>().fruitData.fruitIcon + " icon");

        // Ensure both components exist before trying to sync
        if (uiImage != null && sourceSpriteRenderer != null)
        {
            uiImage.sprite = GetComponentInChildren<Melodrop>().fruitData.fruitIcon;
            // Set the UI Image's sprite to the source SpriteRenderer's current sprite
            uiImage.sprite = sourceSpriteRenderer.sprite;
            Debug.Log("2. Getting " + uiImage.GetComponentInChildren<SpriteRenderer>().sprite + " sprite");
        }
    }

    // You could also add a method to update the sprite dynamically if the source changes
    public void UpdateSprite()
    {
        Debug.Log("Got to updateSprite method");
        if (uiImage != null && sourceSpriteRenderer != null)
        {
            uiImage.sprite = sourceSpriteRenderer.sprite;
        }
    }
}
