/*
 * (Conner Ogle)
 * (Assignment3)
 * (Assignment 3)
 * (Observer to update text gui and display victory)
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
            foreach (Valuable valuable in valuables)
            {
                if (valuable.cube == true)
                {
                    textToDisplay += "Cube: " + valuable.valuableName;
                    textToDisplay += " Found: " + valuable.found.ToString() + "\n";
                }
            }
            textToDisplay += "Squares Left: " + (5 - PlayerInfo.objectsFound) + "\n";
            gameObject.GetComponent<Text>().text = textToDisplay;
        }

        public void victory()
        {
            if (PlayerInfo.objectsFound == 5)
            {
                textToDisplay = "You have found all the cubes!! Victory is yours!" + "\n" + "(Press R to restart)" ;
                gameObject.GetComponent<Text>().text = textToDisplay;
            }
            if (PlayerInfo.hidden == true)
            {
                textToDisplay = "YOU FOUND THE HIDDEN CAPSULE?!? YOU HAVE DOOMED US ALL!!!" + "\n" + "(Press R to restart)";
                gameObject.GetComponent<Text>().text = textToDisplay;
            }
        }

    }
}
