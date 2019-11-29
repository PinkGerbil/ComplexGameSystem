using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testWallRemove : MonoBehaviour {

    public GameObject Right_Wall; 
    public GameObject Left_Wall; 
    public GameObject Down_Wall; 
    public GameObject Up_Wall; 
    
    public bool Connected_Right;
    public bool Connected_Left;
    public bool Connected_Down;
    public bool Connected_Up;
    
    /// <summary>
    /// Use this for initialization 
    /// </summary>
    void Start () {
        Connected_Right = true;
        Connected_Left = true;
        Connected_Down = true; 
        Connected_Up = true; 
    }

    /// <summary>
    /// returns the game object right wall
    /// </summary>
    /// <returns>
    /// the right wall game object
    /// </returns>
    public GameObject GetRightWall()
    {
        return Right_Wall;
    }

    /// <summary>
    /// returns the game object left wall
    /// </summary>
    /// <returns>
    /// the left wall game object
    /// </returns>
    public GameObject GetLeftWall()
    {
        return Left_Wall;
    }

    /// <summary>
    /// returns the game object down wall
    /// </summary>
    /// <returns>
    /// the down wall game object
    /// </returns>
    public GameObject GetDownWall()
    {
        return Down_Wall;
    }
    
    /// <summary>
    /// returns the game object up wall
    /// </summary>
    /// <returns>
    /// the up wall game object
    /// </returns>
    public GameObject GetUpWall()
    {
        return Up_Wall;
    }

    /// <summary>
    /// changes whether or not right wall is active in the scene
    /// </summary>
    /// <param name="Value">a Bool</param>
    public void SetRightWall(bool Value)
    {
        Right_Wall.SetActive(Value);
    }

    /// <summary>
    /// sets whether or not left wall is active
    /// </summary>
    /// <param name="Value">A Bool</param>
    public void SetLeftWall(bool Value)
    {
        Left_Wall.SetActive(Value);
    }

    /// <summary>
    /// Sets down wall to active or inactive
    /// </summary>
    /// <param name="Value">A Bool</param>
    public void SetDownWall(bool Value)
    {
        Down_Wall.SetActive(Value);
    }

    /// <summary>
    /// Sets the up wall to active or inactive
    /// </summary>
    /// <param name="Value">A bool</param>
    public void SetupWall(bool Value)
    {
        Up_Wall.SetActive(Value);
    }
}
