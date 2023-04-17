/*
 * (Conner Ogle)
 * (Assignment11)
 * (Assignment 11)
 * (Class that moves the target and wall)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment11
{
    public class Target : MonoBehaviour
    {
        public Vector3 targetPosition;
        public Vector3 wallPosition;
        public GameObject targetWall;

        // Start is called before the first frame update
        void Start()
        {
            targetPosition = gameObject.transform.position;
            wallPosition = gameObject.transform.position;
        }

        // Update is called once per frame
        void Update()
        {


        }
        public void MoveBack()
        {
            Vector3 newTargetPosition = new Vector3(targetPosition.x - 1.0f,0,0);
            Vector3 newWallPosition = new Vector3(wallPosition.x - 1.0f, 0, 0);

            transform.Translate(newTargetPosition);
            targetWall.transform.Translate(newWallPosition);
        }
    }
}