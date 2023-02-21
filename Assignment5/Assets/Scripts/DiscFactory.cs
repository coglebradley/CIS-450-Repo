/*
 * (Conner Ogle)
 * (Assignment5)
 * (Assignment 5)
 * (The factory which will receive input and gather the desired prefab)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment5
{
    public class DiscFactory : MonoBehaviour
    {
        public GameObject BigPrefab;
        public GameObject MidPrefab;
        public GameObject SmallPrefab;
        private GameObject discSpawn;

        public GameObject CreateDisc(string type)
        {
            discSpawn = null;

            if (type.Equals("Small"))
            {
                discSpawn = SmallPrefab;
            }
            else if (type.Equals("Mid"))
            {
                discSpawn = MidPrefab;
            }
            else if (type.Equals("Big"))
            {
                discSpawn = BigPrefab;
            }
            return discSpawn;
                        
        }
    }
}