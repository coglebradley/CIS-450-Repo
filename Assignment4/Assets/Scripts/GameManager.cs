using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assignment4
{
    
    public class GameManager : MonoBehaviour
    {
        public GameObject[] collectPrefabs;
        private float spawnDelay = 1f;
        private float spawnInterval = 3f;
        public bool gameOver;
        public BallMovement BallMoveScript;
        public Text intro;


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
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            if (Input.GetKey(KeyCode.F))
            {
                intro.enabled = false;
            }
            if (BallMoveScript.score >= 75)
            {
                intro.enabled = true;
                intro.text = "You have achieved Victory!";
            }
        }


        void Spawner ()
        {
            Vector3 spawnLocation = new Vector3(Random.Range(-42, 12), 0.5f, Random.Range(-24, 38));
            int index = Random.Range(0, collectPrefabs.Length);

            Instantiate(collectPrefabs[index], spawnLocation, collectPrefabs[index].transform.rotation);
        }
    }
}
