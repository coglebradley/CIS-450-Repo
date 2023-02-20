using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment5
{
    public class PlayerScript : MonoBehaviour
    {

        public float CameraSpeed;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.A) && transform.position.x > -25)
            {
                transform.position += Vector3.left * Time.deltaTime * CameraSpeed;
            }
            if (Input.GetKey(KeyCode.D) && transform.position.x < 12)
            {
                transform.position += Vector3.right * Time.deltaTime * CameraSpeed;
            }

            if (Input.GetKey(KeyCode.Alpha1))
            {
                return;
            }
            if (Input.GetKey(KeyCode.Alpha2))
            {
                return;
            }
            if (Input.GetKey(KeyCode.Alpha3))
            {
                return;
            }
        }
    }
}