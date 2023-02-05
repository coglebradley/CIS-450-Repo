/* Example Code for Game Programming Design Patterns
 * Author: Owen Schaffer
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ObserverPatternAssignment
{
    //Attach this class to a UI text object to display the text
    public class VictoryProgress : MonoBehaviour, IObserver
    {
        //Allow me to access this script from attach Gameobject by adding this to inspector
        public ValuableData valuableData;

        //Do not create a reference like this for static classes
        //public PlayerInfo playerInfo;

        private string textToDisplay;

        void Start()
        {
            textToDisplay = gameObject.GetComponent<Text>().text;

            valuableData.RegisterObserver(this);
        }

        public void UpdateData(List<Valuable> valuables)
        {
            textToDisplay = "";
            foreach (Valuable location in valuables)
            {
                textToDisplay += "Square: " + location.valuableName + ".\n";
                textToDisplay += "Found: " + location.found.ToString() + ".\n";
            }
            textToDisplay += "Squares Left: " + (5 - PlayerInfo.objectsFound) + ".\n";
            gameObject.GetComponent<Text>().text = textToDisplay;
        }

    }
}
