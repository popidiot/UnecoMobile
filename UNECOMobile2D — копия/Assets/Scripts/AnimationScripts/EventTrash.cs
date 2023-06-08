using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrash : MonoBehaviour
{
     void Start()
    {
        stop = true;
    }
    public bool stop;
    private EventTrash eventTrash;
    [Obsolete]
    void OnMouseDown()
    {
        if (GameObject.FindGameObjectWithTag("Quest").GetComponent<QuestEvent>().Quest2 == true)
        {
            Animation collect = GetComponent<Animation>();
            if (collect.Play("collect"))
            {
                Debug.Log("Onm");


                eventTrash = GetComponent<EventTrash>();
                eventTrash.enabled = false;
                if (stop == true)
                {
                    EventProgress.trashProgress++;
                }

                stop = false;
            }
        }

    }
}
