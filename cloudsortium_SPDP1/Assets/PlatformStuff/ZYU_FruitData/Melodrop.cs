using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Melodrop : MonoBehaviour
{
    public FruitData fruitData;
    private AudioSource audioSource;
    //public InventoryManager inventoryManagerScript;

    void Start()
    {  
       GetComponent<SpriteRenderer>().sprite = fruitData.fruitIcon;
       audioSource = GetComponent<AudioSource>();
       //inventoryManagerScript = GameObject.Find("Inventory_Holder").GetComponent<InventoryManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMovement player = other.GetComponent<PlayerMovement>();
            //FruitTracker.Instance.touchedFruit.text = fruitData.gainedMessage; 
            //reference the tmp in fruit tracker and pull the message from the scriptable object and display it

            if (fruitData.fruitName == "Boingdrop")
            {
                player.StartCoroutine(player.SpeedBoost());
            }
            else if (fruitData.fruitName == "Giftdrop")
            {
                player.StartCoroutine(player.JumpPower());
            }
            else if (fruitData.fruitName == "Boostdrop")
            {
                Timer timerScript = FindFirstObjectByType<Timer>();
                timerScript.currentTime += 10f; //adds ten seconds to timer
            }
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

        //inventoryManagerScript.AddItemtoInventory(gameObject);

         Destroy(gameObject);
        // ^^ removed to instead re-parent it to the inventory
        // & hopefully visualize that info on the canvas w/ the HotbarImageDisplay class

        //if this item is tagged" insert consumable fruit name " then
        //acitvate this! reference player movement for movement changes  UHHH COME BACK HERE
    }

    /*public void MoveToInventory()
    {
        
    }*/
}