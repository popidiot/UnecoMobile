using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventLake : MonoBehaviour
{
    EventProgress EP;
    EventProgress progress;
    private EventLake eventLake;
    public bool stop;

    private void Awake()
    {/*
        Animation Clean = GetComponent<Animation>();
        Clean.Play("Clean");
        */
    }
    void Start()
    {
        stop = true;
        //Animation Clean = GetComponent<Animation>();

    }

    void Update()
    {
        /*
                if (Input.OnMouseDown)
                {
                    Animation Clean = GetComponent<Animation>();
                    Clean.Play("Clean");
                }

        */
    }

    [Obsolete]
    void OnMouseDown()
    {
        if (GameObject.FindGameObjectWithTag("Quest").GetComponent<QuestEvent>().Quest1 == true) { 
        Animation Clean = GetComponent<Animation>();
        if (Clean.Play("Clean"))
        {
            Debug.Log("Onm");


            eventLake = GetComponent<EventLake>();
            eventLake.enabled = false;
           if (stop==true)
            { 
                EventProgress.Progress++; 
            }
        
            stop = false;
        }
        }

    }
        


}

