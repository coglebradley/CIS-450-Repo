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

        public GameObject green;
        public GameObject blue;
        public GameObject red;
        public GameObject yellow;
        public GameObject orange;


        public void RegisterObserver(IObserver observer)
        {
            //Add observer to list of observers
            observers.Add(observer);

            if (valuables != null)
            {
                observer.Progress(valuables);
            }
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                //sends cube data to observer
                observer.Progress(valuables);

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
            //cubes in scene are added to the list
            valuables.Add(valuable);

            NotifyObservers();
        }


    }
}
