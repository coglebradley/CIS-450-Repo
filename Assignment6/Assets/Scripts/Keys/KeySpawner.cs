using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment6
{
    public class KeySpawner : MonoBehaviour
    {
        public KeyFactory factory;
        public GameObject key;
        // Start is called before the first frame update
        public KeySpawner(KeyFactory factory)
        {
            this.factory = factory;
        }

        // Update is called once per frame
        public GameObject SpawnKey(string type, Vector3 keySpot)
        {
            key = factory.CreateKey(type);

            Vector3 spot = new Vector3(keySpot.x, keySpot.y, keySpot.z + 4);

            GameObject keySpawned = Instantiate(key, spot, key.transform.rotation);

            return keySpawned;
        }
    }
}