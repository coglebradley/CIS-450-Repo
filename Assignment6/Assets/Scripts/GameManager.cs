using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public ArtifactDropOff ArtifactDropOffScript;
    public Text text;
    public Text found;
    // Start is called before the first frame update
    void Start()
    {
        ArtifactDropOffScript = GameObject.FindGameObjectWithTag("DropOff").GetComponent<ArtifactDropOff>();
    }

    // Update is called once per frame
    void Update()
    {
        found.text = "Artifacts Found: " + ArtifactDropOffScript.artifactsFound;
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKey(KeyCode.F))
        {
            text.enabled = false;

        }
    }
}
