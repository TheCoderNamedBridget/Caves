﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    
[SerializeField] 
Transform Caveman;

[SerializeField] 
Transform target;


float speed = 6f;

Vector2 targetPos;

GameObject button;
 


private void Start()
{
    //button = GameObject.Find("Button");
    targetPos = transform.position;
}
 
void Update ()
{
transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));

    if(Input.GetMouseButtonDown(0))
    {
        //Todo fix character flip
        // Debug.Log("Cavemane positon x " + Caveman.transform.position.x + " Mouse pos x " + Input.mousePosition.x/25);
        // if ( ((Vector2)transform.position).x < targetPos.x)
        // {
        //     Debug.Log("inside " + transform.position.x + " < " + targetPos.x);
        //     Caveman.GetComponent<SpriteRenderer>().flipX = true;
        // } 
        // else if (((Vector2)transform.position).x < targetPos.x)
        // {
        //     Debug.Log("inside " + transform.position.x + " > " + targetPos.x);
        //     Caveman.GetComponent<SpriteRenderer>().flipX = false;
        // }
        

        targetPos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target.position = targetPos;
     
    }
    if((Vector2)transform.position != targetPos)
    {
       transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
       
    }
}



// void OnMouseOver()
// {
//     Debug.Log(gameObject.name);
// }   

    //Code to make caveman move with
    // [SerializeField]
    // private float moveSpeed = 5f;

    // [SerializeField]
    // private float jumpSpeed = 2f;
    
    // [SerializeField]
    // private GameObject Caveman;


      
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {

    //     if (Input.GetButton("Horizontal")){
    //         if (Input.GetKey("right"))
    //         {
    //             print("right arrow key is held down");
    //             Caveman.GetComponent<SpriteRenderer>().flipX = false;
    //             Caveman.transform.position += new Vector3(moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0);
    //         }

    //         if (Input.GetKey("left"))
    //         {
    //             print("left arrow key is held down");
    //             Caveman.GetComponent<SpriteRenderer>().flipX = true;
    //             Caveman.transform.position += new Vector3(moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0);
    //         }

    //         //Debug.Log("Tried to move");
            

    //     }

    //     if (Input.GetKey("up"))
    //     {
    //         Caveman.transform.position += new Vector3(0, moveSpeed * Time.deltaTime * Input.GetAxis("Vertical"), 0);
    //     }

    //     if (Input.GetKey("down"))
    //     {
    //         Caveman.transform.position += new Vector3(0, moveSpeed * Time.deltaTime * Input.GetAxis("Vertical"), 0);
    //     }

        

    // }
}
