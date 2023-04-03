using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace StatePatternGameObjects
{
    //Attach this class to a UI text object to display the text
    public class DisplayText : MonoBehaviour
    {
        //need to drag these objects into these reference in the inspector
        public EnemyAIStateManager enemyAIStateManager;
        public EnemyController enemyController;


        private string textToDisplay;


        // Start is called before the first frame update
        void Start()
        {
            this.textToDisplay = gameObject.GetComponent<Text>().text;
        }

        // Update is called once per frame
        void Update()
        {
            this.textToDisplay = "";

            this.textToDisplay += "Current Enemy State: " + enemyAIStateManager.currentState + "\n";

            this.textToDisplay += "Distance from player: " + enemyController.distanceFromPlayer + ".\n";
            gameObject.GetComponent<Text>().text = this.textToDisplay;
        }
    }
}