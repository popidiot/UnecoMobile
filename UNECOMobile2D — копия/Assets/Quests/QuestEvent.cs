using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class QuestEvent : MonoBehaviour
{
    public bool Quest1;
    public bool Quest2;
    public GameObject Text1;
    public GameObject Text2;
    public bool end_Quest1;
    DialogeNextClick DialogClick;
    public 
    void Start()
    {
        Quest1 = false;
        
    
    }

   
    void Update()
        
    {
        
      
            if (Quest1 == true)
            {
            
                Text1.SetActive(true);
            }
            else
            {
                Text1.SetActive(false);
            }

        if (Quest2 == true)
        {

            Text2.SetActive(true);
        }
        else
        {
            Text2.SetActive(false);
        }


    }
}
