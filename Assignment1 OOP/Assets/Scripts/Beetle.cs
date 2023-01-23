/*
 * (Conner Ogle)
 * (Assignment1 OOP)
 * (Assignment1)
 * (new class created from creature, Beetle)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Beetle : Creature, IAttack, IWalk
{
    public int hitpoints = 55;

    public override void Die()
    {
        Debug.Log("beetle dies");
    }
    public void Walk()
    {
        Debug.Log("Beetle Moves");
    }

public void Attack()
{
    Debug.Log("Beetle deals damage");
}
}
