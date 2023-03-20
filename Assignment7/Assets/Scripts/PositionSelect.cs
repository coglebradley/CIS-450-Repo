/*
 * (Conner Ogle)
 * (Assignment7)
 * (Assignment 7)
 * (Select what key the player wants)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assignment7
{
    public class PositionSelect : MonoBehaviour
    {
        public int keyPosition;
        public int keySelected;
        public Text text;
        void Start()
        {
            text.text = "Key Selected: " + keySelected;
        }
        void Update()
        {
            text.text = "Key Selected: " + keySelected;
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                keySelected = 1;
                keyPosition = 0;
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                keySelected = 2;
                keyPosition = 1;
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                keySelected = 3;
                keyPosition = 2;
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                keySelected = 4;
                keyPosition = 3;
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                keySelected = 5;
                keyPosition = 4;
            }
        }
    }
}
