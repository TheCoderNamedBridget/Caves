// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class AnimalMovement : MonoBehaviour
// {

//     [SerializeField]
//     private float moveSpeed = 5f;

    
//     [SerializeField]
//     private GameObject Animal;


      
//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {

//         if (Input.GetButton("Horizontal")){
//             if (Input.GetKey("right"))
//             {
//                 print("right arrow key is held down");
//                 Animal.GetComponent<SpriteRenderer>().flipX = false;
//             }

//             if (Input.GetKey("left"))
//             {
//                 print("left arrow key is held down");
//                 Animal.GetComponent<SpriteRenderer>().flipX = true;
//             }

//             //Debug.Log("Tried to move");
//             Animal.transform.position += new Vector3(moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0);

//         }

//         if (Input.GetButton("Vertical")){

//             Debug.Log("Inside Vert");
//             Animal.transform.position += new Vector3(0, moveSpeed * Time.deltaTime * Input.GetAxis("Vertical"), 0);

//         }

        

//     }
// }
