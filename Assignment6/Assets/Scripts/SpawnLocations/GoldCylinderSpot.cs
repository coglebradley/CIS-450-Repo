/*
 * (Conner Ogle)
 * (Assignment6)
 * (Assignment 6)
 * (Gold Artifact Spawner)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment6
{
    public class GoldCylinderSpot : MonoBehaviour
    {
        public GameObject artifact;
        public ArtifactFactory factory;
        public ArtifactSpawner spawner;
        public Vector3 artifactSpot;

        void Start()
        {
            artifactSpot = this.transform.position;
        }
        // Start is called before the first frame update
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "BlueCylinder")
            {
                artifact = spawner.SpawnArtifact("GoldCylinder", artifactSpot);
                Destroy(other);
                Destroy(gameObject);
            }
        }
    }
}
