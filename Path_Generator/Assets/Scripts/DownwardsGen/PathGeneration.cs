using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathGeneration : MonoBehaviour {

    public GameObject RightRoom;
    public GameObject LeftRoom;
    public GameObject BottomRoom;

    //only used for the removal of walls
    //look back at this in case of other pathway tryings
    public GameObject AboveRoom;

    public GameObject winFlag;

    public testWallRemove wallRemove;

    public bool ConnectedLeft;
    public bool ConnectedRight;
    public bool ConnectedAbove;
    public bool ConnectedDown;

    public bool traversed;
    public bool endRoom;

	/// <summary>
    /// When it starts it will initialize some variables
    /// </summary>
	void Start () {
        traversed = false;
        ConnectedLeft = false;
        ConnectedRight = false;
        ConnectedAbove = false;
        ConnectedDown = false;
    }
	
	/// <summary>
    /// Called every frame
    /// </summary>
	void Update () {
        //checks if current room has been traversed 
        if (!traversed)
        {
            //Spawns a path from that room
            PathSpawn();
            //checks to see what room are active around it
            checkActiveRooms();
        }
        //checls to see if the win flag exists
        if(winFlag != null)
        {
            //Checks to see if the current room is the end room 
            if (!endRoom)
            {
                //if it is not it will set the end flag to inactive
                winFlag.SetActive(false);
            }
            else
            {
                //if the room is the end it will active the win flag
                winFlag.SetActive(true);
            }
        }
	}

    /// <summary>
    /// Spawns a room adjacent to the current room
    /// </summary>
    void PathSpawn()
    {
        //randomly selects a number between 1 & 3
        //Range([inclusive],[exclusive])
        int randomRoomSpawn = Random.Range(1, 4);
        //print(randomRoomSpawn);
        if (randomRoomSpawn == 1)
        {
            //bottom path
            //Spawns room below current room
            SpawnBotRoom(); 
            //sets the room to traversed
            traversed = true;
        }
        else if (randomRoomSpawn == 2)
        {
            // Spawns the room to the left
            SpawnLeftRoom();
            //sets the room to traversed
            traversed = true;
        }
        else if (randomRoomSpawn == 3)
        {
            // spawns the room to the right
            SpawnRightRoom();
            //sets the room to traversed
            traversed = true;
        }

    }

    /// <summary>
    /// Spawns the room below the current one
    /// </summary>
    void SpawnBotRoom()
    {
        //checks to see if the room below exists
        if (BottomRoom != null)
        {
            //Activates the room below
            BottomRoom.SetActive(true);
            //sets the connection to a room below to true
            ConnectedDown = true; 
        }
        else
        {
            //sets the current room to the end room
            endRoom = true;
        }
    }
    
    /// <summary>
    /// Spawns the room to the left 
    /// </summary>
    void SpawnLeftRoom()
    {
        //checks to see if the left room is null
        if (LeftRoom == null)
        {
            //if the left room doesnt exist it will go into the spawn right room code
            SpawnRightRoom();
        }
        else
        {
            //checks to see if the left room is already active in the scene
            if (LeftRoom.activeInHierarchy)
            {
                //checks to see if the bottom room is null
                if (BottomRoom != null)
                {
                    //activates the bottom room
                    BottomRoom.SetActive(true);
                }
                else
                {
                    //if there is no bottom room it will set it as the end room 
                    endRoom = true;
                }
            }
            else
            {
                //sets the left room to true
                LeftRoom.SetActive(true);
            }
        }
    }

    /// <summary>
    /// Spawns the room to the right
    /// </summary>
    void SpawnRightRoom()
    {
        //checks to see if the room to the right is active
        if (RightRoom == null)
        {
            //spawns the room to the left if the right room is null
            SpawnLeftRoom();
        }
        else
        {
            //checks to see if the right room is active
            if (RightRoom.activeInHierarchy)
            {
                //checks to see if the bottom room is null
                if (BottomRoom != null)
                {
                    //sets the bottom room to true
                    BottomRoom.SetActive(true);
                }
                else
                {
                    //if the bottom room is null set end room to true
                    endRoom = true;
                }
            }
            else
            {
                //sets the room to the right to true
                RightRoom.SetActive(true);
            }
        }
    }

    /// <summary>
    /// checks to see which adjacent rooms are active
    /// </summary>
    void checkActiveRooms()
    {
        //checks to see if the right room is null
        if(RightRoom != null)
        {
            //checks to see if the right room is active in the scene
            if (RightRoom.activeInHierarchy)
            {
                //removes the wall to the right if that room is active
                wallRemove.SetRightWall(false);
            }
            else
            {
                //if right room is inactive the wall will remain
                wallRemove.SetRightWall(true);
            }
        }
        //checks to see if the right room is null
        if (LeftRoom != null)
        {
            //checks to see if the left room is active in the current scene
            if (LeftRoom.activeInHierarchy)
            {
                //removes the left wall if the room is active
                wallRemove.SetLeftWall(false);
            }
            else
            {
                //if the room is inactive the wall will remain
                wallRemove.SetLeftWall(true);
            }
        }
        //checks to see if the room below is null
        if(BottomRoom != null)
        {
            //checks to see if the room below is active in the current scene
            if (BottomRoom.activeInHierarchy)
            {
                //removes the down wall if the room below is active
                wallRemove.SetDownWall(false);
            }
            else
            {
                //the wall will remain if the room is inactive
                wallRemove.SetDownWall(true);
            }
        }
        //checks to see if the room above is null
        if (AboveRoom != null)
        {
            //checks to see if the room above is active in the current scene
            if (AboveRoom.activeInHierarchy)
            {
                //removes the above wall if the room up is active
                wallRemove.SetupWall(false);
            }
            else
            {
                //keeps the wall there if the room above is inactive
                wallRemove.SetupWall(true);
            }
        }
    }
}
