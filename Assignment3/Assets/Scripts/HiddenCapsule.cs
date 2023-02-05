using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPatternAssignment
{
    public class HiddenCapsule : Valuable
    {

        //Allow me to access this script from attach Gameobject by adding this to inspector

        public new void Start()
        {
            valuablePosition = gameObject.transform.position;
            valuableData.AddValuable(this);
        }

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
