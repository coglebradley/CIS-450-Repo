/*
 * (Conner Ogle)
 * (Assignment3)
 * (Assignment 3)
 * (interface for observer object)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPatternAssignment
{
    public interface IObserver
    {
        void Progress(List<Valuable> valuables);

        void victory();

    }
}
