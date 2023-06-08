using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Task : MonoBehaviour
{
    public bool EndDialog;
    public GameObject Dialog1;
    public GameObject Dialog2;
    public QuestEvent QuestEvent;
    public bool FinDialog;
    private bool OnHide;
    private DialogeNextClick End;
    public GameObject Dialog3;
  

    // Update is called once per frame
    void Update()
    {
       
        if (EndDialog == true)
        {
            Time.timeScale = 1;
            QuestEvent.Quest1 = true;
            Dialog1.SetActive(false);

        }
     
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            Time.timeScale = 0;
            Dialog1.SetActive(true);
            if (EventProgress.Progress == 3)
            {
                Dialog2.SetActive(true);
            }
            if  (GameObject.FindGameObjectWithTag("Dialog_1fin").GetComponent<DialogeNextClick>().finDialog == false)
            {
                
                Dialog3.SetActive(true);
                Debug.Log("dsad");
            }
        }
    }
            /* 
             if (FinDialog == false)
            {
                Time.timeScale = 0;
                if (QuestEvent.end_Quest1 == false)
                {
                    Dialog1.SetActive(true);
                }
                else
                {
                    Dialog2.SetActive(true);
                }
            }
           else
            {
                if (OnHide == false) 
                { 
                Dialog2.SetActive(true) ;
                    OnHide = true;
                }
            }
            */

        
    
}
