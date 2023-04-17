/*
 * (Conner Ogle)
 * (Assignment11)
 * (Assignment 11)
 * (Class player uses to hit ball)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment11
{
    
    public class PlayerController : MonoBehaviour
    {
        public float xForce = -25;

        public GameObject ball;

        public Rigidbody rb;

        // Start is called before the first frame update
        void Start()
        {
            rb = ball.GetComponent<Rigidbody>();
        }


        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.tag == "Ball")
                    {
                        rb.AddForce(-25*xForce, 0, 0);
                    }


                }
            }   
        }
        public void VelocityIncrease()
        {
            xForce = xForce *2;
        }

    }
}