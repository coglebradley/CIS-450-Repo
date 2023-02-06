/*
 * (Conner Ogle)
 * (Assignment3)
 * (Assignment 3)
 * (Extension of valuable)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPatternAssignment
{
    public class HiddenCapsule : Valuable
    {

        //This is called when the Player enters the trigger this script is attached to
        public new void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player" && found == false)
            {
                PlayerInfo.hidden = true;
                valuableData.NotifyObservers();
            }

        }
    }
}
