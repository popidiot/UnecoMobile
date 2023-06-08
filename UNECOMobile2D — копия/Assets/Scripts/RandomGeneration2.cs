using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGeneration2 : MonoBehaviour
{
    public int numberObject; // количество объектов
    public GameObject[] objects;
    private int generatedObject = 0;
    public float minRange, maxRange; // территория спавна

    void Update()
    {
        if(generatedObject < numberObject)
        {
            Generate();
            generatedObject++;
        }
    }
    
    public void Generate()
    {
        int rand = Random.Range(0, objects.Length);
        var cell = Instantiate(objects[rand], transform.position, Quaternion.identity);
        cell.transform.position = new Vector3(Random.Range(minRange,maxRange), Random.Range(minRange,maxRange), transform.position.z);
    }

}
