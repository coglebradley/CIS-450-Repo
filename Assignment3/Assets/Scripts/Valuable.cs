/* 
 *
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPatternAssignment
{
    //Attach this class to GameObjects with colliders in the scene
    public class Valuable : MonoBehaviour
    {
        public string valuableName;
        public bool found;
        public int progress;
        public Vector3 valuablePosition;

        //Allow me to access this script from attach Gameobject by adding this to inspector
        public ValuableData valuableData;

        public void Start()
        {
            valuablePosition = gameObject.transform.position;
            valuableData.AddValuable(this);
        }

        //This is called when the Player enters the trigger this script is attached to
        public void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player" && found == false)
            {
                found = true;
                PlayerInfo.objectsFound += this.progress;
                valuableData.NotifyObservers();
            }

        }

    }
}
