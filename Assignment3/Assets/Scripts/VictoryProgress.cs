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
    public class VictoryProgress : MonoBehaviour, IObserver
    {
        //Allow me to access this script from attach Gameobject by adding this to inspector
        public ValuableData valuableData;
        public GameObject cubey;
        public GameObject player;



        private string textToDisplay;

        void Start()
        {
            //registers this as an observer and get the text used
            textToDisplay = gameObject.GetComponent<Text>().text;

            valuableData.RegisterObserver(this);
        }
        //sets the player cube to active after finding the in game object
        public void Progress(List<Valuable> valuables)
        {
            foreach (Valuable valuable in valuables)
            {

                if (valuable.cube == true)
                {
                    if(valuable.found == true)
                    {
                        valuable.attachedCube.SetActive(true);
                    }
                    
                }
            }

        }

        //displays victory text
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
