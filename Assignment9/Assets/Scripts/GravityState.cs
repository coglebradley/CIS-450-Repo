/*
 * (Conner Ogle)
 * (Assignment9)
 * (Assignment 9)
 * (State that switches gravity of the player)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment9
{
    public class GravityState : PlayerState
    {
        PlayerStateController playerStateController;
        public GravityState(PlayerStateController playerStateController)
        {
            this.playerStateController = playerStateController;
        }
        public void Gravity(bool gravityOn, Rigidbody rb)
        {
            Debug.Log("Gravity Something");

        }

        public void Moving(int Direction, Rigidbody rb)
        {
            throw new System.NotImplementedException();
        }

        public void Stop(Rigidbody rb)
        {
            playerStateController.currentState = playerStateController.stationaryState;
            //rb.useGravity = false;
            //rb.AddForce(0, 0, 0, ForceMode.Force);
            //rb.constraints = RigidbodyConstraints.None;

        }

    }
}
