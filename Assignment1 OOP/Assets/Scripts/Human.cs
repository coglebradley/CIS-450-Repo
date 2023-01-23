/*
 * (Conner Ogle)
 * (Assignment1 OOP)
 * (Assignment1)
 * (new class created from creature, Human)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Human : Creature, IAttack, IWalk
    {
        public string name = "Steve";

        public override void Die()
        {
            Debug.Log("Human dies");
        }
        public void Walk()
        {
            Debug.Log("Human Moves");
        }
        
        public void Attack()
        {
            Debug.Log("Human deals damage");
        }
    }
