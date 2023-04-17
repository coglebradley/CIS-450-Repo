/*
 * (Conner Ogle)
 * (Assignment11)
 * (Assignment 11)
 * (Keeps track of the bounces and produces text)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assignment11
{
    public class WinTracker : MonoBehaviour
    {
        public int bounces;

        public Text bounceCount;

        public Text text;

        public bool finishTut = false;
        // Start is called before the first frame update
        void Start()
        {
            bounces = 0;

            text.text = "This is Bounce Ball! You need to click on the ball and try to get it to hit the target. When you succesfully hit the target it will move further back and you will hit with more force! Try to hit the target 10 times with as little bounces as possible. Press F to play and press R to restart at any time. Good luck!";

            bounceCount.text = "Bounces: " + bounces;

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            if (Input.GetKey(KeyCode.F) && finishTut == false)
            {
                text.enabled = false;
                text.text = "Try to hit the target 10 times with as little bounces as possible. Press F to play and press R to restart at any time. Good luck!";
            }
            /*if (Input.GetKey(KeyCode.F) && finishTut == true)
            {
                text.enabled = false;
            }*/
        }
        public void increaseBounce()
        {
            bounces++;

            bounceCount.text = "Bounces: " + bounces;
        }
        public void Victory()
        {
            text.text = "You won with " + bounces + " bounces! Want to try to get a better score? Hit R!";
        }
    }
}