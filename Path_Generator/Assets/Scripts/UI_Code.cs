using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Code : MonoBehaviour {
    
    /// <summary>
    /// Reloads the current scene
    /// </summary>
    public void RestartScene()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex));
    }
}
