/*
 * (Conner Ogle)
 * (Assignment6)
 * (Assignment 6)
 * (Blue Key Spawner location)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment6
{
    public class BlueCylinder : MonoBehaviour
    {
        public GameObject key;
        public KeyFactory factory;
        public KeySpawner spawner;
        public Vector3 keySpot;

        void Start()
        {
            keySpot = this.transform.position;
        }
        // Start is called before the first frame update
        private void OnTriggerEnter(Collider other)
        {
            if(other.tag == "Player")
            {
                key = spawner.SpawnKey("BlueCylinder",keySpot);
            }
        }
    }
}