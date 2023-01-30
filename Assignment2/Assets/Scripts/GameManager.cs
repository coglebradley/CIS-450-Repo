/*
* (Conner Ogle)
* (Assignment 2)
* (Game Manager to operate the game)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    private PlayerBall playerBallScript;
    public GameObject BallP;
    public TextMeshPro intro;
    // Start is called before the first frame update
    void Start()
    {
        playerBallScript = GameObject.Find("Player").GetComponent<PlayerBall>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.B))
        {
            playerBallScript.Normal();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            playerBallScript.Smaller();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKey(KeyCode.F))
        {
            intro.enabled = false;
        }
    }
}
