/*
 * (Conner Ogle)
 * (Assignment5)
 * (Assignment 5)
 * (Script that allows player to throw discs and move camera)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment5
{
    public class PlayerScript : MonoBehaviour
    {
        public GameObject disc;
        public float CameraSpeed;
        public DiscFactory factory;
        public DiscSpawner spawner;
        Rigidbody discRigid;
        public float thrust = 1000f;

        // Start is called before the first frame update
        void Start()
        {
            Vector3 discSpot = transform.position;

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.A) && transform.position.x > -25)
            {
                transform.position += Vector3.left * Time.deltaTime * CameraSpeed;
            }
            if (Input.GetKey(KeyCode.D) && transform.position.x < 12)
            {
                transform.position += Vector3.right * Time.deltaTime * CameraSpeed;
            }

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                disc = spawner.SpawnDisc("Big");

                discRigid = disc.GetComponent<Rigidbody>();

                discRigid.AddForce(transform.forward*thrust, ForceMode.Impulse);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                disc = spawner.SpawnDisc("Mid");

                discRigid = disc.GetComponent<Rigidbody>();

                discRigid.AddForce(transform.forward * thrust, ForceMode.Impulse);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                disc = spawner.SpawnDisc("Small");

                discRigid = disc.GetComponent<Rigidbody>();

                discRigid.AddForce(transform.forward * thrust, ForceMode.Impulse);
            }
        }



    }
}