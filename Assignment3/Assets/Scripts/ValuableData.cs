/*
 * (Conner Ogle)
 * (Assignment3)
 * (Assignment 3)
 * (gameobject that holds functions that other classes will reference)
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

namespace ObserverPatternAssignment
{
    //Attach this to an empty GameObject in the scene
    public class ValuableData : MonoBehaviour, ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        public List<Valuable> valuables = new List<Valuable>();

        public void RegisterObserver(IObserver observer)
        {
            //Add observer to list of observers
            observers.Add(observer);

            if (valuables != null)
            {
                //Updates data for newly added observer
                observer.UpdateData(valuables);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }
        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                //include data as parameters to UpdateData
                observer.UpdateData(valuables);
                Debug.Log("UpdateData was called from Notify Observers");
            }
        }

        public void VictoryObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.victory();
                Debug.Log("Victory has been achieved");
            }
        }

        public void AddValuable(Valuable valuable)
        {
            //adds valuables in scene
            valuables.Add(valuable);

            NotifyObservers();
        }


    }
}
