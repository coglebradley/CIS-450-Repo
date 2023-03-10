/*
 * (Conner Ogle)
 * (Assignment3)
 * (Assignment 3)
 * (interface for subjects)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPatternAssignment
{

    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void NotifyObservers();
    }


}
