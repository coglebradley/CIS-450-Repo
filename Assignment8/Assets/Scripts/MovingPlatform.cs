/*
 * (Conner Ogle)
 * (Assignment8)
 * (Assignment 8)
 * (Platform that moves after it is touched. To throw the player off)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Characters.FirstPerson
{
    public class MovingPlatform : Platform
    {
        public float x;
        public float y;
        public float z;
        public override void Action()
        {
            gameObject.transform.position = new Vector3(x,y,z);
        }

        public void OnColliderEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                JumpHeight();
                Action();

            }
        }
    }
}