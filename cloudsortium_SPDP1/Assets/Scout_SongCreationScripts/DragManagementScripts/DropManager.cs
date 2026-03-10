using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropManager : MonoBehaviour, IDropHandler
{
    public int inventorySize;
    public string keyMelodropString;

    public melodropPlacement placement;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Dropped Item");
        GameObject droppedItem = eventData.pointerDrag;

        if (transform.childCount < inventorySize)
        {
            droppedItem.GetComponent<ItemInfo>().lastPosition = transform;
        }

        Debug.Log("Doing the melodropPlacement event");
        placement.Invoke(droppedItem.GetComponent<Image>().sprite.name);
    }

}
[System.Serializable]
public class melodropPlacement : UnityEvent<string>
{ }