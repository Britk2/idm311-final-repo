using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void ReplayButton()
    {
        Debug.Log("Replay Debug");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
        }
    }
}
