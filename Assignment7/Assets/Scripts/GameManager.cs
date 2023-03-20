using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assignment7
{
    public class GameManager : MonoBehaviour
    {
        public Text text;
        public string solution;
        public MoveKey MoveKey;
        private Command KeyMoveRight;
        private Command KeyMoveLeft;
        // Start is called before the first frame update

        public Stack<Command> commandHistory;
        void Start()
        {
            solution = "stack";
            text.text = "Welcome to Word Scramble! \nThe goal is to unscramble the word to create a real word. You can select a character based on its position using the keys 1-5. The left most character is position 1. Once you have a key selected use the left and right arrow keys to advance its position. You can undo a move by pressing E. When you think your word is done hit enter! \nPress F to play";
            KeyMoveLeft = new KeyMoveLeft(MoveKey);
            KeyMoveRight = new KeyMoveRight(MoveKey);
            commandHistory = new Stack<Command>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                text.text = "ksact";
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (text.text == solution)
                {
                    text.text = "You have won the game! Hit R to restart.";
                }
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                KeyMoveLeft.Execute();
                commandHistory.Push(KeyMoveLeft);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                KeyMoveRight.Execute();
                commandHistory.Push(KeyMoveRight);
            }

            if (Input.GetKey(KeyCode.E))
            {
                if (commandHistory.Count != 0)
                {
                    
                    Command lastCommand = commandHistory.Pop();

                    lastCommand.Undo();
                }
            }
        }
    }
}