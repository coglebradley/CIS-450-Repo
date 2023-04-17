/*
 * (Conner Ogle)
 * (Assignment11)
 * (Assignment 11)
 * (Facade class that calls functions)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment11
{


    public class FacadeBouncer : MonoBehaviour
    {
        public PlayerController playercontroller;

        public WinTracker wintracker;

        public Target target;

        public Rigidbody rb;



        public float rbSpeed;

        public int hits;


        // Start is called before the first frame update
        void Start()
        {

            
            rb = gameObject.GetComponent<Rigidbody>();
            rbSpeed = rb.velocity.magnitude;

        }

        void GroundContact()
        {
            wintracker.increaseBounce();
        }

        void HitTarget()
        {
            hits++;
            target.MoveBack();
            playercontroller.VelocityIncrease();
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            gameObject.transform.Translate(0,5,0);
        }

        void gameOver()
        {
            wintracker.Victory();
        }


        void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.tag == "Target")
            {
                HitTarget();
            }
            else if (collision.transform.tag == "Ground")
            {
                GroundContact();
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (hits >= 10)
            {
                gameOver();
            }
        }
    }
}