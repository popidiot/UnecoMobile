using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DialogeNextClick : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
    private bool isText1 = true;
    public NPC_Task npc_taskScript;
    public bool finDialog;
    public GameObject ObjectQuest;
    public bool Enddialog;
    public QuestEvent QuestEvent1;
    public GameObject[] Dialog1;
   public GameObject[] Dialog2;

    private void Start()
    {
        
        Dialog1 = GameObject.FindGameObjectsWithTag("Dialog1");
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isText1 == true ) 
            { 
            isText1 = false;
            }
            else
            {
                
                   isText1 = true;
                
                Enddialog = true;
                finDialog = false;


            }

            
        }
        if (isText1 ==  true) {
            Text1.SetActive(true);
            Text2.SetActive(false);
            
        } else
        {
            Text1.SetActive(false);
            Text2.SetActive(true);
           
        }
        if (Enddialog == true)
        {
           
            Time.timeScale = 1;
            GameObject.FindGameObjectWithTag("Quest").GetComponent<QuestEvent>().Quest1 = true;
           



            foreach (GameObject Dia in Dialog1) 
            {
                Dia.SetActive(false);
                finDialog = true;
                
            }
            

            // Dialog1.SetActive(false);
        }
        if (finDialog == true)
        {
            Time.timeScale = 1;
            foreach (GameObject Dia in Dialog2)
            {
                GameObject.FindGameObjectWithTag("Quest").GetComponent<QuestEvent>().Quest1 = false;
                Dia.SetActive(false);
                GameObject.FindGameObjectWithTag("Quest").GetComponent<QuestEvent>().Quest2 = true;
                //finDialog = true;
            }

        }
       
        
    }
}
