/*
 * (Conner Ogle)
 * (Assignment10)
 * (Assignment 10)
 * (Object pooler)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
   
    public List<Spawn> spawns;


    public Dictionary<string, Queue<GameObject>> spawnDic;



    public static ObjectSpawner instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        spawnDic = new Dictionary<string, Queue<GameObject>>();

        FillInactiveObjects();

    }

    
    private void FillInactiveObjects()
    {
        foreach (Spawn spawn in spawns)
        {
            
            Queue<GameObject> spawnList = new Queue<GameObject>();

            
            for (int i = 0; i < spawn.amount; i++)
            {
                
                GameObject obj = Instantiate(spawn.prefab);
                
                obj.SetActive(false);

                spawnList.Enqueue(obj);
            }

            spawnDic.Add(spawn.reference, spawnList);
        }
    }


    public GameObject Spawn(string reference, Vector3 position, Quaternion rotation)
    {
       
        GameObject objectToSpawn = spawnDic[reference].Dequeue();

        
        objectToSpawn.SetActive(true);
        
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;


        spawnDic[reference].Enqueue(objectToSpawn);

        
        return objectToSpawn;
    }

    public void ReturnObject(string reference, GameObject objectToReturn)
    {
        
        objectToReturn.SetActive(false);


        spawnDic[reference].Enqueue(objectToReturn);

    }
    public IEnumerator Spawning(string reference, Vector3 position, Quaternion rotation)
    {
        Spawn(reference, position, rotation);
        yield return new WaitForSeconds(2f);

        
    }

}
