using UnityEngine;
using UnityEngine.EventSystems;

public class Inventory : MonoBehaviour, IDropHandler
{
    public int inventorySize;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("moved item back to inventory");
        GameObject droppedItem = eventData.pointerDrag;

        if (transform.childCount < inventorySize)
        {
            droppedItem.GetComponent<ItemInfo>().lastPosition = transform;
        }

    }

}
