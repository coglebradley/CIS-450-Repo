/*
* (Conner Ogle)
* (Assignment 4)
* (Gameobject with the middle value attached for collecting)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment4
{
    public class MiddleValue : ColorDecorator
    {
        public new int value = 15;
        public BallMovement BallMoveScript;
        Collectable collectable;


/*        void Start()
        {
            if (BallMoveScript == null)
            {
                BallMoveScript = GameObject.FindGameObjectWithTag("Player").GetComponent<BallMovement>();
            }

        }*/
        public MiddleValue(Collectable collectable)
        {
            this.collectable = collectable;
        }


        /*public void OnCollisionEnter(Collision collision)
        {
                BallMoveScript.score += GetValue();
                Destroy(this.gameObject);

        }*/
        /*public void OnTriggerEnter(Collider other)
        {
            if(other.tag == "Player")
            {
                BallMoveScript.score += GetValue();
                Destroy(this.gameObject);
            }
        }*/
    }
}