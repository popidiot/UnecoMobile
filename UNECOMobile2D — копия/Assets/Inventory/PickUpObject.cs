using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Serialization;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public Item item;
    private GameObject itemObj;


    private void Start()
    {
        itemObj = gameObject;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Inventory.instance.PutInEmptySlot(item);
            itemObj.SetActive(false);
           

        }
    }
}

