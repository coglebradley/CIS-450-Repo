/*
 * (Conner Ogle)
 * (Assignment3)
 * (Assignment 3)
 * (game manager that restarts scene and manages basic gameplay)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ObserverPatternAssignment
{
    public class GameManager : MonoBehaviour
    {
        public ValuableData valuableData;



        void Start()
        {
            PlayerInfo.hidden = false;
            PlayerInfo.objectsFound = 0;
            valuableData.NotifyObservers();
        }


        void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

            if (PlayerInfo.objectsFound == 5 || PlayerInfo.hidden == true)
            {
                valuableData.VictoryObservers();
            }

        }
    }
}
