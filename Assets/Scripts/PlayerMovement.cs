using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    //public float jumpSpeed = 2f;
    public GameObject Caveman;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal")){

            if (Input.GetKey("right"))
            {
                print("right arrow key is held down");
                Caveman.GetComponent<SpriteRenderer>().flipX = false;
            }

            if (Input.GetKey("left"))
            {
                print("left arrow key is held down");
                Caveman.GetComponent<SpriteRenderer>().flipX = true;
            }

            //Debug.Log("Tried to move");
            Caveman.transform.position += new Vector3(moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0);

        }

        if (Input.GetButton("Vertical")){

            Debug.Log("Inside Vert");
            Caveman.transform.position += new Vector3(0, moveSpeed * Time.deltaTime * Input.GetAxis("Vertical"), 0);

        }

        if (Input.GetKeyDown("space"))
        {
            Caveman.transform.position += new Vector3(0, moveSpeed * Time.deltaTime * Input.GetAxis("Vertical"), 0);
        }
        
        // if (Input.GetButton("Jump")){
        //     boxboi.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpSpeed));
        // }
        
        //to move with the arrow up keys
        // if (Input.GetButton("Vertical")){
        //     Caveman.transform.position += new Vector3(0, moveSpeed * Time.deltaTime * Input.GetAxis("Vertical"), 0);
        // }
    }
}
