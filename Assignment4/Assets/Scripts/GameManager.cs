using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment4
{
    
    public class GameManager : MonoBehaviour
    {
        public GameObject[] collectPrefabs;
        private float spawnDelay = 1f;
        private float spawnInterval = 3f;
        public bool gameOver;
        public BallMovement BallMoveScript;


        // Start is called before the first frame update
        void Start()
        {


            InvokeRepeating("Spawner", spawnDelay, spawnInterval);

            if (BallMoveScript == null)
            {
                BallMoveScript = GameObject.FindGameObjectWithTag("Player").GetComponent<BallMovement>();
            }


        }

        // Update is called once per frame
        void Update()
        {

        }


        void Spawner ()
        {
            Vector3 spawnLocation = new Vector3(Random.Range(-42, 12), 0.5f, Random.Range(-24, 38));
            int index = Random.Range(0, collectPrefabs.Length);

            Instantiate(collectPrefabs[index], spawnLocation, collectPrefabs[index].transform.rotation);
        }
    }
}
