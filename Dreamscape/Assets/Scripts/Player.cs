//Title: Week 6: Conditional Statements, Switch Statements & Player Input
//Author: Hayes, A.
//Date: 22/04/2025
//Code version: -
//Availability: www.ulwazi.witz.ac.za

using UnityEngine;

public class Test : MonoBehaviour
{

    public int movespeed = 4;
    public GameObject Player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = this.gameObject; 
    }

    void MovePlayer()
    {
        Vector3 movePosition = Vector3.zero; //(0,0,0)


        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            movePosition.y += 1; //(0,1,0)
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            movePosition.y -= 1; //(0,-1,0)
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            movePosition.x -= 1; //(-1,0,0)
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            movePosition.x += 1; //(1,0,0)
        }                                                                        //every second not every frame
        Player.transform.position += movePosition.normalized * movespeed * Time.deltaTime; //keeps movement position locked
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();    
    }

}
