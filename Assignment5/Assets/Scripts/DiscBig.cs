/*
 * (Conner Ogle)
 * (Assignment5)
 * (Assignment 5)
 * (One of the children of disc to be thrown)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment5
{
    public class DiscBig : Disc
    {
        public GameManager GameManagerScript;
        void Start()
        {
            GameManagerScript = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        }
        public DiscBig()
        {
            this.DiscType = "Big";
            this.Points = 6;
        }
        public void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.tag == "Target")
            {
                GameManagerScript.score += Points;
                Destroy(other.gameObject);
                Destroy(gameObject);
            }
            else if(other.gameObject.tag == "Bounds")
            {
                GameManagerScript.score -= 3;
                Destroy(gameObject);
            }

        }
    }

}