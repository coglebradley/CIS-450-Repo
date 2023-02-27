/*
 * (Conner Ogle)
 * (Assignment6)
 * (Assignment 6)
 * (Spawner for Artifacts)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment6
{
    public class ArtifactSpawner : MonoBehaviour
    {
        public ArtifactFactory factory;
        public GameObject artifact;
        // Start is called before the first frame update
        public ArtifactSpawner(ArtifactFactory factory)
        {
            this.factory = factory;
        }

        // Update is called once per frame
        public GameObject SpawnArtifact(string type, Vector3 artifactSpot)
        {
            artifact = factory.CreateArtifact(type);

            Vector3 spot = new Vector3(artifactSpot.x, artifactSpot.y, artifactSpot.z + 4);

            GameObject artifactSpawned = Instantiate(artifact, spot, artifact.transform.rotation);

            return artifactSpawned;
        }
    }
}
