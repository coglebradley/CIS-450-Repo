/*
* (Conner Ogle)
* (Assignment 4)
* (Gameobject with the highest value attached for collecting)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment4
{
    public class HighValue : ColorDecorator
    {
        public new int value = 25;
        Collectable collectable;

        public HighValue(Collectable collectable)
        {
            this.collectable = collectable;
        }

    }
}