/*
* (Conner Ogle)
* (Assignment 4)
* (Creates offset for the camera to follow ball at)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment4
{
    public class CameraSet : MonoBehaviour
    {

        public GameObject player;
        private Vector3 offset;
        // Start is called before the first frame update
        void Start()
        {
            offset = transform.position - player.transform.position;
        }

        // Update is called once per frame
        void LateUpdate()
        {
            transform.position = player.transform.position + offset;
        }
    }
}
