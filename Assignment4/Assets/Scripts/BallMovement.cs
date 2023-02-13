/*
* (Conner Ogle)
* (Assignment 4)
* (Controlling the ball's movement and collision with collectables)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment4
{
    public class BallMovement : MonoBehaviour
    {
        public float speed = 5.0f;
        public Rigidbody rb;
        public Vector3 movement;
        public int score;
        private int scoreToAdd;

        public Collectable collectable;

        // Start is called before the first frame update
        void Start()
        {
            rb = this.GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {

            movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        }
        void FixedUpdate()
        {
            moveBall(movement);
        }
        void moveBall(Vector3 direction)
        {
            rb.AddForce(direction * speed);
        }
        /*private void OnCollisionEnter(Collision collision)
        {
            GameObject other = collision.gameObject;
            if (other.CompareTag("Mid"))
            {
                scoreToAdd = other.GetComponent<MiddleValue>().GetValue();

                score += scoreToAdd;
                Destroy(collision.gameObject);
            }
            
        }*/

        public void OnTriggerEnter(Collider other)
        {
            Grabable grabable = other.gameObject.GetComponent<Grabable>();
            if(other.tag == "Cube")
            {
                ScoreAdder(grabable);
                Destroy(other.gameObject);

            }
        }

        private void ScoreAdder(Grabable grabable)
        {
            if (grabable.collectableType == Grabable.CollectableType.low)
            {
                collectable = new LowValue(collectable);
                score += collectable.value;
            }
        }
    }
}