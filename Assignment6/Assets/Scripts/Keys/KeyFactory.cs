using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment6
{
    public class KeyFactory : MonoBehaviour
    {
        public GameObject BlueSphereKey;
        public GameObject BlueCubeKey;
        public GameObject BlueCylinderKey;
        public GameObject RedSphereKey;
        public GameObject RedCubeKey;
        public GameObject RedCylinderKey;
        public GameObject KeySpawn;
        // Start is called before the first frame update
        public GameObject CreateKey(string type)
        {
            KeySpawn = null;
            if(type.Equals("BlueCylinder"))
            {
                KeySpawn = BlueCylinderKey;
            }

            return KeySpawn;
        }
    }
}