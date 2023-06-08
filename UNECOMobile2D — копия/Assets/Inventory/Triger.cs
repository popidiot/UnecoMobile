using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;


public class Triger : MonoBehaviour
{
    private static Inventory InventoryChek;
    private InventorySlot[] Slotforchek = new InventorySlot[6];
    public ID IDDDD;
    GameObject fuck2;
    bool ready = true;
    public int IDDD;


    //сделать Область тригера в котором будет работать кнопка только при наличии нужных инструментов
    /// <summary>
    /// зафигачить проверку на id каждого gameObject Slot
    /// </summary>
    private void Start()
    {
      // SetChildrenActiveState(false);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Inventory.instance.CheckForID(IDDDD);
            //if (InventorySlot.IDD ) //блять долбоёб накидал айдишники по скриптам и не может найти
            //if (Identificator = InventorySlot.IDD)
           // GameObject.Find(Slot);
            //SetChildrenActiveState(true);
                //gameObject.SetActive(false);

        }
    }
    
    

}
