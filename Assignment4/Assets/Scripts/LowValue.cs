/*
* (Conner Ogle)
* (Assignment 4)
* (Gameobject with the lowest value attached for collecting)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment4
{

    public class LowValue : ColorDecorator
    {
        public new int value = 5;
        Collectable collectable;
        public BallMovement BallMoveScript;

        public LowValue(Collectable collectable)
        {
            this.collectable = collectable;
        }

        void Start()
        {
            if (BallMoveScript == null)
            {
                BallMoveScript = GameObject.FindGameObjectWithTag("Player").GetComponent<BallMovement>();
            }

        }

    }
}