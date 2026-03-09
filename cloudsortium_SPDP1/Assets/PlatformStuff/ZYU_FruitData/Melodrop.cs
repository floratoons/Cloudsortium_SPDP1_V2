using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melodrop : MonoBehaviour
{
    public FruitData fruitData;
    private AudioSource audioSource;
    public InventoryManager inventoryManagerScript;

    void Start()
    {  
       GetComponent<SpriteRenderer>().sprite = fruitData.fruitIcon;
       audioSource = GetComponent<AudioSource>();
       inventoryManagerScript = GameObject.Find("Inventory_Holder").GetComponent<InventoryManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Collect();
        }
    }

    void Collect()
    {
        AudioSource.PlayClipAtPoint(fruitData.pickUp, transform.position);

        if (FruitTracker.Instance != null && fruitData != null)
        {
            FruitTracker.Instance.AddFruit(fruitData.fruitName);
        }

        if (transform.parent != null)
        {
            transform.parent.SendMessage("OnFruitCollected", SendMessageOptions.DontRequireReceiver);
        }

        inventoryManagerScript.AddItemtoInventory(gameObject);

        // Destroy(gameObject);
        // ^^ removed to instead re-parent it to the inventory
        // & hopefully visualize that info on the canvas w/ the HotbarImageDisplay class

        //if this item is tagged" insert consumable fruit name " then
        //acitvate this! reference player movement for movement changes  UHHH COME BACK HERE
    }

    /*public void MoveToInventory()
    {
        
    }*/
}