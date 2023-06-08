using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Item SlotItem;
    Image icon;
    Button button;
    public int IDD;

    private void Start()
    {
        icon = gameObject.transform.GetChild(0).GetComponent<Image>();
        //button = GetComponent<Button>();
    }

    public void PutInSlot(Item item)
    {
        icon.sprite = item.icon;
        SlotItem = item;
        icon.enabled = true;
        IDD = item.id;
    }
}