/*
 * (Conner Ogle)
 * (Assignment10)
 * (Assignment 10)
 * (Script to decide spawn location for objects)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLocation : MonoBehaviour
{

    ObjectSpawner objectSpawner;

    public bool spawnCubes;


    private void Start()
    {
        objectSpawner = ObjectSpawner.instance;
    }

    void FixedUpdate()
    {
            StartCoroutine(Spawner());     
    }

    IEnumerator Spawner()
    {
        Vector3 spawnOrange = Vector3.zero;
        Vector3 spawnBlue = Vector3.zero;

        while (spawnCubes == true)
        {
            yield return new WaitForSeconds(2f);

            spawnOrange.x = Random.Range(-9f,9f);
            spawnOrange.y = Random.Range(0f,4f);
            spawnOrange.z = Random.Range(-13f,4f);

            spawnBlue.x = Random.Range(-9f, 9f);
            spawnBlue.y = Random.Range(0f, 4f);
            spawnBlue.z = Random.Range(-13f, 4f);

            //objectSpawner.Spawning("Orange", spawnOrange, Quaternion.identity);

            objectSpawner.Spawn("Orange", spawnOrange, Quaternion.identity);
            //objectSpawner.Spawning("Blue", spawnBlue, Quaternion.identity);
            objectSpawner.Spawn("Blue", spawnBlue, Quaternion.identity);

        }
        
    }
}
