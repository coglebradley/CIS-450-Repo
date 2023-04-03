/*
 * (Conner Ogle)
 * (Assignment9)
 * (Assignment 9)
 * (State that moves the player)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment9
{
    public class MovingState : PlayerState
    {
        PlayerStateController playerStateController;
        public MovingState(PlayerStateController playerStateController)
        {
            this.playerStateController = playerStateController;
        }
        public void Gravity(bool gravityOn, Rigidbody rb)
        {
            if (gravityOn == false)
            {
                playerStateController.currentState = playerStateController.gravityState;
                rb.useGravity = true;

            }

        }

        public void Moving(int Direction, Rigidbody rb)
        {
            Debug.Log("No Moving");
        }

        public void Stop(Rigidbody rb)
        {
            playerStateController.currentState = playerStateController.stationaryState;
            rb.AddForce(0, 0, 0, ForceMode.Force);
        }

    }
}
