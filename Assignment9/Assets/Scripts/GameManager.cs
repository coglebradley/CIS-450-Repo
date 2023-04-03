/*
 * (Conner Ogle)
 * (Assignment9)
 * (Assignment 9)
 * (Manage scene and text)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assignment9
{
    
    public class GameManager : MonoBehaviour
    {
        public Text text;
        PlayerStateController playerStateControllerScript;
        // Start is called before the first frame update
        void Start()
        {
            playerStateControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStateController>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            if (Input.GetKey(KeyCode.F))
            {
                text.enabled = false;
            }
            if (playerStateControllerScript.won == true)
            {
                text.text = "Victory is yours! Press R to play again!";
            }
        }
    }
}