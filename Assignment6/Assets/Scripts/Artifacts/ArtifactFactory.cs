using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment6
{
    public class ArtifactFactory : MonoBehaviour
    {
        public GameObject GoldSphereArtifact;
        public GameObject GoldCubeArtifact;
        public GameObject GoldCylinderArtifact;
        public GameObject SilverSphereArtifact;
        public GameObject SilverCubeArtifact;
        public GameObject SilverCylinderArtifact;
        public GameObject artifactSpawn;
        // Start is called before the first frame update
        public GameObject CreateArtifact(string type)
        {
            artifactSpawn = null;
            if (type.Equals("GoldCylinder"))
            {
                artifactSpawn = GoldCylinderArtifact;
            }

            return artifactSpawn;
        }
    }
}
