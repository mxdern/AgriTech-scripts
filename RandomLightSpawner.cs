using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{

    public GameObject light;
    public GameObject targetGameObject;

    public int min_NumberOfLights;
    public int max_NumberOfLights;

    public int range;

    Vector3 position;

    void Update()
    {

        //Delete the previous frames lights
        GameObject[] tags = GameObject.FindGameObjectsWithTag("tag1");
        foreach (GameObject item in tags)
            GameObject.Destroy(item);

        //Create new random light sources
        SpawnRandom();

    }

    void SpawnRandom()
    {

        int NumberOfLights = Random.Range(min_NumberOfLights, max_NumberOfLights + 1);

        for (int i = 0; i < NumberOfLights; i++)
        {
            Vector3 targetposition = targetGameObject.transform.position;

            position = targetposition + new Vector3(Random.Range(-range, range), Random.Range(-range, range), Random.Range(-range, range));
            GameObject clone = (GameObject)Instantiate(light, position, Quaternion.identity);

            clone.tag = "tag1";
        }
    }



}


