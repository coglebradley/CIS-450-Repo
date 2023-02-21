/*
 * (Conner Ogle)
 * (Assignment5)
 * (Assignment 5)
 * (Spawner class to instantiate a wanted disc)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment5
{

    public class DiscSpawner : MonoBehaviour
    {
        public DiscFactory factory;
        public GameObject discSpot;
        public GameObject disc;

        public DiscSpawner(DiscFactory factory)
        {
            this.factory = factory;
        }

        public GameObject SpawnDisc(string type)
        {

            disc = factory.CreateDisc(type);

            GameObject discSpawned = Instantiate(disc, discSpot.transform.position, disc.transform.rotation * Quaternion.Euler (90f,0,0f));

            return discSpawned;

        }


    }
}