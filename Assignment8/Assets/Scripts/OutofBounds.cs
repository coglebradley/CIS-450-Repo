/*
 * (Conner Ogle)
 * (Assignment8)
 * (Assignment 8)
 * (Script that returns player in bounds)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutofBounds : MonoBehaviour
{

    public GameObject Player;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Player.transform.position = new Vector3(0f, 10f, 0f);
        }
    }
}
