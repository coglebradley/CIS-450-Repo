using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment9
{
    public class PlayerStateController : MonoBehaviour
    {
        public PlayerState stationaryState { get; set; }
        public PlayerState movingState { get; set; }
        public PlayerState gravityState { get; set; }


        public PlayerState currentState { get; set; }


        public bool gravityOn = false;
        public Rigidbody rb;
        public int Direction;
        public bool won = false;

        public void Moving(int Direction, Rigidbody rb) { currentState.Moving(Direction, rb); }
        public void Gravity(bool gravityOn, Rigidbody rb) { currentState.Gravity(gravityOn, rb); }
        public void Stop(Rigidbody rb) { currentState.Stop(rb); }

        void Start()
        {
            stationaryState = new StationaryState(this);
            movingState = new MovingState(this);
            gravityState = new GravityState(this);

            currentState = stationaryState;
            rb = GetComponent<Rigidbody>();
            
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Direction = 0;
                Moving(Direction, rb);

            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Direction = 1;
                Moving(Direction, rb);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Direction = 2;
                Moving(Direction, rb);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Current enemy state: " + currentState);
            }

        }
        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.tag == "Wall")
            {
                Stop(rb);
            }
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "GravityPad")
            {
                Gravity(gravityOn, rb);
            }
            if (other.tag == "WinPad")
            {
                won = true;
            }
        }
    }
}
