/*
 * (Conner Ogle)
 * (Assignment8)
 * (Assignment 8)
 * (Game manager for restarting the scene)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace UnityStandardAssets.Characters.FirstPerson
{
    public class GameManager : MonoBehaviour
    {
        public Text text;
        // Start is called before the first frame update

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                text.enabled = false;
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}