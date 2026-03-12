using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ItemInfo : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //public Item currentItem;
    //public GameObject displayItem;
    public string itemName;
    public Transform lastPosition;
    public Image itemIcon;
    public AudioClip audioClip;

    private void Start()
    {
        //displayItem = GameObject.FindGameObjectWithTag("displayText");
        itemIcon = GetComponent<Image>();
    }

    public void itemClick()
    {
        //Debug.Log(currentItem.name + " clicked");
        //displayObj.GetComponent<TextMeshProUGUI>().text = currentItem.itemName;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("Begin Drag");
        lastPosition = transform.parent;
        transform.SetParent(lastPosition.root);
        transform.SetAsLastSibling();
        itemIcon.raycastTarget = false;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("End Drag");
        transform.position = lastPosition.position;
        transform.SetParent(lastPosition);
        itemIcon.raycastTarget = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("Dragging");
        transform.position = Mouse.current.position.ReadValue();
    }
}
