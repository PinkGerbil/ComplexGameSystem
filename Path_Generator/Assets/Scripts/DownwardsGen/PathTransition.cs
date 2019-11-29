using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PathTransition : MonoBehaviour {
    private static int floorNumber = 1;
    public Text text;

    /// <summary>
    /// Initializes variables
    /// </summary>
    private void Start()
    {
        if(text != null)
        {
            text.text = "Floor " + floorNumber;
        }
    }

    /// <summary>
    /// checks to see if an object has entered the collider
    /// </summary>
    /// <param name="other">A collider </param>
    private void OnTriggerEnter(Collider other)
    {
        //checks to see what the active scene's build index is
        if(SceneManager.GetActiveScene().buildIndex > 0)
        {
            //goes down a scene
            GoDownScene();
        }
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            //SceneManager.GetActiveScene().name == "genStyle";
            //goes up a scene
            GoUpScene();
        }
    }

    /// <summary>
    /// will go to the next scene in the build index
    /// </summary>
    public void GoUpScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        changetext();
    }

    /// <summary>
    /// will go to the previous scene in the build index
    /// </summary>
    public void GoDownScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    private void changetext()
    {
        text.text = "Floor " + floorNumber;
        floorNumber++;
    }
}
