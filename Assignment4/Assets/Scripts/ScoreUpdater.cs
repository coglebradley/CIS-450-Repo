using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assignment4
{
    public class ScoreUpdater : MonoBehaviour
    {
        public Text textbox;
        public BallMovement BallMoveScript;
        void Start()
        {


            if(BallMoveScript == null)
            {
                BallMoveScript = GameObject.FindGameObjectWithTag("Player").GetComponent<BallMovement>();
            }
        }

        // Update is called once per frame
        void Update()
        {
            textbox.text = "Score: " + BallMoveScript.score;
        }
    }
}