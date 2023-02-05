/* Example Code for Game Programming Design Patterns
 * Author: Owen Schaffer
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

        internal void AddValuable(HiddenCapsule hiddenCapsule)
        {
            throw new NotImplementedException();
        }

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

        public void AddValuable(Valuable valuable)
        {
            //adds valuables in scene
            valuables.Add(valuable);

            NotifyObservers();
        }


    }
}
