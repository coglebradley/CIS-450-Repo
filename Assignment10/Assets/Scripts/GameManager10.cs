/*
 * (Conner Ogle)
 * (Assignment10)
 * (Assignment 10)
 * (Manage scene and allows player to collect cubes)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager10 : MonoBehaviour
{
    public Text text;
    public int score;
    public Text collect;
    // Start is called before the first frame update
    void Start()
    {
        collect.text = "Orange Grabbed: 0";
        text.text = "Welcome to Cube collector! You can use your mouse to grab the cubes. The goal is to succesfully collect 15 orange cubes. Be careful! Clicking on anything other than the orange cubes will result in you losing one of your cubes. Press F to play and R to restart at any time.";
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKey(KeyCode.F))
        {
            text.enabled = false;
        }

        if (Input.GetMouseButtonDown(0))
        { 
            Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "Orange")
                {
                    score++;
                    collect.text = "Orange Grabbed: " + score;
                }
                if (hit.transform.tag == "Blue")
                {
                    score--;
                    collect.text = "Orange Grabbed: " + score;
                }

                //Destroy(hit.transform);
            }
        }
        if (score >= 15)
        {
            text.text = "You have collected enough cubes! Press R to play again.";
            text.enabled = true;
        }
    }
}
