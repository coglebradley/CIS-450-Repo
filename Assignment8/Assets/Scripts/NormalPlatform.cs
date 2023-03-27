/*
 * (Conner Ogle)
 * (Assignment8)
 * (Assignment 8)
 * (The basic platform that just increases jump height)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityStandardAssets.Characters.FirstPerson
{
    public class NormalPlatform : Platform
    {
        public override void Action()
        {
            Debug.Log("Normal Platform");
        }

        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                JumpHeight();
                Action();
                if (win == true)
                {
                    GameManagerScript.text.text = "You Win!";
                }
            }
        }

    }
}