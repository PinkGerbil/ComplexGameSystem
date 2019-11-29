using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startRoom : MonoBehaviour {

    public GameObject room1;
    public GameObject room2;
    public GameObject room3;
    public GameObject room4;
    public GameObject room5;

    public GameObject floor1_1;
    public GameObject floor1_2;
    public GameObject floor1_3;
    public GameObject floor1_4;
    public GameObject floor1_5;
    public GameObject floor2_1;
    public GameObject floor2_2;
    public GameObject floor2_3;
    public GameObject floor2_4;
    public GameObject floor2_5;
    public GameObject floor3_1;
    public GameObject floor3_2;
    public GameObject floor3_3;
    public GameObject floor3_4;
    public GameObject floor3_5;
    public GameObject floor4_1;
    public GameObject floor4_2;
    public GameObject floor4_3;
    public GameObject floor4_4;
    public GameObject floor4_5;

    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player4;
    public GameObject Player5;

    public GameObject[] rooms;

    public bool cornerRoom;

    /// <summary>
    /// Intializes the variables at the start
    /// </summary>
    void Start () {

        Player1.SetActive(false);
        Player2.SetActive(false);
        Player3.SetActive(false);
        Player4.SetActive(false);
        Player5.SetActive(false);

        int RandomNumber = Random.Range(1, 5);

        if (RandomNumber == 1)
        {
            Player1.SetActive(true);
            room1.SetActive(true);
            room2.SetActive(false);
            room3.SetActive(false);
            room4.SetActive(false);
            room5.SetActive(false);

            cornerRoom = true;
        }
        else if (RandomNumber == 2)
        {
            Player2.SetActive(true);
            room1.SetActive(false);
            room2.SetActive(true);
            room3.SetActive(false);
            room4.SetActive(false);
            room5.SetActive(false);
        }
        else if (RandomNumber == 3)
        {
            Player3.SetActive(true);
            room1.SetActive(false);
            room2.SetActive(false);
            room3.SetActive(true);
            room4.SetActive(false);
            room5.SetActive(false);
        }
        else if (RandomNumber == 4)
        {
            Player4.SetActive(true);
            room1.SetActive(false);
            room2.SetActive(false);
            room3.SetActive(false);
            room4.SetActive(true);
            room5.SetActive(false);
        }
        else if (RandomNumber == 5)
        {
            Player5.SetActive(true);
            room1.SetActive(false);
            room2.SetActive(false);
            room3.SetActive(false);
            room4.SetActive(false);
            room5.SetActive(true);

            cornerRoom = true;
        }
        
        floor1_1.SetActive(false);
        floor1_2.SetActive(false);
        floor1_3.SetActive(false);
        floor1_4.SetActive(false);
        floor1_5.SetActive(false);
        floor2_1.SetActive(false);
        floor2_2.SetActive(false);
        floor2_3.SetActive(false);
        floor2_4.SetActive(false);
        floor2_5.SetActive(false);
        floor3_1.SetActive(false);
        floor3_2.SetActive(false);
        floor3_3.SetActive(false);
        floor3_4.SetActive(false);
        floor3_5.SetActive(false);
        floor4_1.SetActive(false);
        floor4_2.SetActive(false);
        floor4_3.SetActive(false);
        floor4_4.SetActive(false);
        floor4_5.SetActive(false);
    }
    /// <summary>
    /// returns whether or not this room is a corner room
    /// </summary>
    /// <returns>
    /// the bool of cornerRoom
    /// </returns>
    public bool getCornerRoom()
    {
        return cornerRoom;
    }

    /// <summary>
    /// checks the 5 random rooms that could've spawned and returns which one did
    /// </summary>
    /// <returns>
    /// the start room that was selected
    /// </returns>
    public GameObject returnActiveRoom()
    {
        //checks to see if the room are active in the scene
        //if they are it will return that room

        if (room1.activeInHierarchy)
        {
            return room1;
        }
        if (room2.activeInHierarchy)
        {
            return room2;
        }
        if (room3.activeInHierarchy)
        {
            return room3;
        }
        if (room4.activeInHierarchy)
        {
            return room4;
        }
        if (room5.activeInHierarchy)
        {
            return room5;
        }
        else
        {
            return null; 
        }
    }

    /// <summary>
    /// Checks to see if paramred name="room"/> is active and returns it if it is
    /// </summary>
    /// <param name="room"></param>
    /// <returns>
    /// returns room if active else will return null
    /// </returns>
    GameObject checkIfActive(GameObject room)
    {
        //checks to see if room is active
        if (room.activeInHierarchy)
        {
            //returns room
            return room;
        }
        //if room is inactive
        else
        {
            //returns null
            return null; 
        }
    }

}
