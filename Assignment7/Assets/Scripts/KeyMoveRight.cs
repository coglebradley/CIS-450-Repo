/*
 * (Conner Ogle)
 * (Assignment7)
 * (Assignment 7)
 * (Move selected key one position to the right)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment7
{

    public class KeyMoveRight : Command
    {
        MoveKey MoveKey;
        Stack<string> wordHistory;

        public KeyMoveRight(MoveKey MoveKey)
        {
            this.MoveKey = MoveKey;
            wordHistory = new Stack<string>();
        }
        public void Execute()
        {
            wordHistory.Push(MoveKey.CurrentString());

            MoveKey.MoveKeyRight();
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