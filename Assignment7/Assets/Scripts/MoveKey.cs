/*
 * (Conner Ogle)
 * (Assignment7)
 * (Assignment 7)
 * (Key mover receiver)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace Assignment7
{
    public class MoveKey : MonoBehaviour
    {
        char[] word;
        public string newWord;
        public char currentKey;
        public char nextKey;
        public int keyPosition;
        public Text text;
        public PositionSelect PositionSelectScript;

        // Start is called before the first frame update
        void Start()
        {
            PositionSelectScript = GameObject.FindGameObjectWithTag("Select").GetComponent<PositionSelect>();
        }
        public string CurrentString()
        {
            newWord = text.text;
            return newWord;
        }
        public void MoveKeyLeft()
        {
            if (keyPosition != 0)
            {
                word = text.text.ToCharArray();
                currentKey = word[keyPosition];
                nextKey = word[keyPosition - 1];

                word[keyPosition] = nextKey;
                word[keyPosition - 1] = currentKey;

                newWord = new string(word); 
            }

        }

        public void MoveKeyRight()
        {
            if (keyPosition < 6)
            {
                word = text.text.ToCharArray();
                currentKey = word[keyPosition];
                nextKey = word[keyPosition + 1];

                word[keyPosition] = nextKey;
                word[keyPosition + 1] = currentKey;

                newWord = new string(word);
            }
        }
        void Update()
        {
            keyPosition = PositionSelectScript.keyPosition;
        }
    }
}