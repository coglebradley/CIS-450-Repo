/*
 * (Conner Ogle)
 * (Assignment8)
 * (Assignment 8)
 * (The player will have to guess these platforms. Will disappear based on bool)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityStandardAssets.Characters.FirstPerson
{
    public class GuessPlatform : Platform
    {
        public bool falsePlatform;
        public override void Action()
        {
            if (falsePlatform == true)
            {
                Destroy(gameObject);
            }
            
        }

        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                JumpHeight();
                Action();

            }
        }
    }
}