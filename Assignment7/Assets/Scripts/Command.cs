/*
 * (Conner Ogle)
 * (Assignment7)
 * (Assignment 7)
 * (Command Interface)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment7
{

    public interface Command
    {
        void Execute();
        void Undo();
    }

}