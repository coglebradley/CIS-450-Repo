/*
 * (Conner Ogle)
 * (Assignment5)
 * (Assignment 5)
 * (GameManager script to deal with spawn of targets, scene management, and score)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] targets;
    private float spawnDelay = 1f;
    private float spawnInterval = 4.2f;
    public int score;
    public Text text;
    public Text message;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawner", spawnDelay, spawnInterval);
        message.text = "You have entered the world of Disc Throw. Use A and D to move the camera left and right. Your mission is to use the 1, 2, and 3 keys to throw different sized discs and score 100 points. The big disc is on the 1 key, medium on 2, small on 3. The smaller the disc, " +
            "the more points you get for hitting a target! Beware, there are some hard to hit targets and if you miss you will be penalized and the penality will be greater the smaller the disc is! Press F when you are ready to play! You can hit R to reload the game";

    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score : " + score;
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKey(KeyCode.F))
        {
            message.enabled = false;

        }
        if (score >= 100)
        {
            message.enabled = true;
            message.text = "You have achieved Victory! Press R to play again!";
            CancelInvoke();
        }
    }
    void Spawner()
    {
        Vector3 spawnLocation = new Vector3(Random.Range(-25, 12), 1.5f, 34);
        int index = Random.Range(0, targets.Length);

        Instantiate(targets[index], spawnLocation, targets[index].transform.rotation);
    }
}
