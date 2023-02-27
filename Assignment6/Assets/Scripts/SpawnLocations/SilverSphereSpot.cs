/*
 * (Conner Ogle)
 * (Assignment6)
 * (Assignment 6)
 * (Silver Artifact Spawner location)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment6
{
    public class SilverSphereSpot : MonoBehaviour
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
            if (other.tag == "RedSphere")
            {
                artifact = spawner.SpawnKey("SilverCylinder", artifactSpot);
                Destroy(other);
                Destroy(gameObject);
            }
        }
    }
}
