/*
 * (Conner Ogle)
 * (Assignment7)
 * (Assignment 7)
 * (Move selected key one position to the left)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment7
{

    public class KeyMoveLeft : Command
    {
        MoveKey MoveKey;
        Stack<string> wordHistory;

        public KeyMoveLeft(MoveKey MoveKey)
        {
            this.MoveKey = MoveKey;
            wordHistory = new Stack<string>();
        }
        public void Execute()
        {
            wordHistory.Push(MoveKey.CurrentString());

            MoveKey.MoveKeyLeft();
        }

        public void Undo()
        {
            if (wordHistory.Count != 0)
            {
                MoveKey.newWord = wordHistory.Pop();
            }
        }


    }
}