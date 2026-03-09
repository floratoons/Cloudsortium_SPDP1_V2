using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using System.Runtime.CompilerServices;

public class InventoryManager : MonoBehaviour
{
    // A static reference to the one and only instance of the manager
    public static InventoryManager Instance;
    FruitTracker fruitTrackerScript;
    public HotbarImageDisplay hotbarImageDisplayScript;

    public int inventorySize = 9;

    public GameObject hotbarGrid;

    public UnityEvent addToInventory;

    void Awake()
    {
        if (Instance == null)
        {
            // If no instance exists, set this one as the instance
            Instance = this;
            // Mark the GameObject to not be destroyed on scene load
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If an instance already exists, destroy this new object to prevent duplicates
            Destroy(gameObject);
        }

        hotbarGrid = GameObject.Find("Inventory_LayoutGroup");
    }

    public void AddItemtoInventory(GameObject collectedDrop)
    {
        if (hotbarGrid.transform.childCount < 9)
        {
            collectedDrop.transform.SetParent(hotbarGrid.transform);
        }
        else
        {
            Destroy(collectedDrop);
        }
    }


}
