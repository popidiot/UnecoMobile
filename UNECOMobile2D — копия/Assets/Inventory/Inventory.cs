using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Unity.VisualScripting;
using System.Diagnostics;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    public Transform SlotsParent;
    public InventorySlot[] inventorySlots = new InventorySlot[6];
    public ID Id;
    public GameObject fuck;
    GameObject fuck2;
    Button button;
    



    private void Start()
    {
        instance = this;

        for (int i = 0; i < inventorySlots.Length; i++)
        {
            inventorySlots[i] = SlotsParent.GetChild(i).GetComponent<InventorySlot>();
        }
        
    }
    public void PutInEmptySlot(Item item)   
    {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            if (inventorySlots[i].SlotItem == null)
            {
                inventorySlots[i].PutInSlot(item);
                return;
            }
           

        }
    }
    
 
    public void CheckForID(ID IDD)
    {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            if (inventorySlots[i].IDD == 1) //вместо 1 должна быть проверка переменной из Area 
            {
                // fuck = GameObject.FindGameObjectWithTag("Slot");
                //transform.FindChild("switch").gameObject.SetActive(false);
                
                //fuck.SetActive(false);
            }
        }
    }
    void SetChildrenActiveState(bool active)
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(active);
        }
    }
    /*public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            for(int i =0; i < inventorySlots.Length; ++i)
            {
                if (inventorySlots[i].SlotItem =)
                {

                }
            }
        }
    }
    */
}
