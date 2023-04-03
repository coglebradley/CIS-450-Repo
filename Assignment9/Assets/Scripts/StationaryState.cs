using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment9
{
    public class StationaryState : PlayerState
    {
        PlayerStateController playerStateController;

        public StationaryState(PlayerStateController playerStateController)
        {
            this.playerStateController = playerStateController;
        }
        public void Gravity(bool gravityOn, Rigidbody rb)
        {
            throw new System.NotImplementedException();
        }

        public void Moving(int Direction, Rigidbody rb)
        {
            playerStateController.currentState = playerStateController.movingState;

            if (Direction == 0)
            {
                rb.AddForce(0, 0, -200, ForceMode.Force);
            }
            else if (Direction == 1)
            {
                rb.AddForce(200, 0, 0, ForceMode.Force);
            }
            else if (Direction == 2)
            {
                rb.AddForce(0, 0, 200, ForceMode.Force);
            }
        }

        public void Stop(Rigidbody rb)
        {
            Debug.Log("Already Stopped!");
        }
    }
}
