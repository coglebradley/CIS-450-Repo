/*
 * (Conner Ogle)
 * (Assignment1 OOP)
 * (Assignment1)
 * (new class created from creature, Monster)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Monster : Creature, IAttack, IWalk
{
    public int hitpoints = 75;

    public override void Die()
    {
        Debug.Log("monster dies");
    }
    public void Walk()
    {
        Debug.Log("Monster Moves");
    }

    public void Attack()
    {
        Debug.Log("Monster deals damage");
    }
}

