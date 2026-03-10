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

    //public UnityEvent addToInventory;

    void Awake()
    {
        hotbarGrid = GameObject.Find("Inventory_LayoutGroup");
        hotbarImageDisplayScript = hotbarGrid.GetComponent<HotbarImageDisplay>();
    }

    public void AddItemtoInventory(GameObject collectedDrop)
    {
        if (hotbarGrid.transform.childCount > 9)
        {
            Destroy(collectedDrop);
        }
        else
        {
            collectedDrop.transform.SetParent(hotbarGrid.transform);
        }
    }
}
