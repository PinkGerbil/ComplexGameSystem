using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb; 
	// Update is called once per frame
	void Update () {

        //checks to see if key is down
        if (Input.GetKey(KeyCode.W))
        {
            //adds force upwards if W is down
            rb.AddForce(0, 0, 10);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //adds force right if D is down
            rb.AddForce(10, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //adds force downwards if S is down
            rb.AddForce(0, 0, -10);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //adds force to the left if A is down
            rb.AddForce(-10, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Escape)){
            //if escape is down it will reload the current scene
            SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex));
        }
    }
}
