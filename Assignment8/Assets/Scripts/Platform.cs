/*
 * (Conner Ogle)
 * (Assignment8)
 * (Assignment 8)
 * (Abstract platform class)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Characters.FirstPerson
{
    public abstract class Platform : MonoBehaviour
    {
        public GameObject Player;

        public bool win;

        public FirstPersonController FirstPersonControllerScript;

        public GameManager GameManagerScript;
        // Start is called before the first frame update
        private void Start()
        {
            Player = GameObject.FindGameObjectWithTag("Player");

            FirstPersonControllerScript = Player.GetComponent<FirstPersonController>();

            
        }
        public abstract void Action();

        public void JumpHeight()
        {
            FirstPersonControllerScript.m_JumpSpeed++;
        }

        public virtual bool IsWin()
        {
            return win = false;
        }
    }
}