using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectQuest : MonoBehaviour
{
    public QuestEvent QEvent;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
           
        }
    }
}
