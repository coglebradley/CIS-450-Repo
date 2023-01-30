/*
* (Conner Ogle)
* (Assignment 2)
* (Script used to change the size of ball)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : PlayerSize
{
    public override void Normal()
    {
        gameObject.transform.localScale = new Vector3(1, 1, 1);
    }

    public override void Smaller()
    {
        gameObject.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
    }

}
