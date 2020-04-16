using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{

    List<Item> Inventory = new List<Item>();



    
//Tells when there is a collision between plaer and another object and then destroys thta object
    void OnCollisionEnter2D(Collision2D collision)
    {
        if ( !collision.gameObject.name.Contains("water"))
        {

        
        Debug.Log("in");

        string ItemName = collision.gameObject.name;

        bool InList = false;

        int indexOfItem = 0;

        for (int i = 0; i < Inventory.Count; i++)
        {
            if (Inventory[i].GetName().Equals(ItemName))
            {
                InList = true;
                indexOfItem = i;
            }
        }


        //Todo: Finish searching inventory for the same items
        //Finish keeping coreect count of the items
        if ( !InList)
        {

            Item objectToPickUp = new Item( ItemName );
            Inventory.Add(objectToPickUp);
            objectToPickUp.AddItem();
            Debug.Log("Name of object = [" + objectToPickUp.GetName() + "] Num Objects [" + objectToPickUp.GetNumItems() +"]");

        } 
        else 
        {

            Inventory[indexOfItem].AddItem();
            Debug.Log("Name of object = [" + Inventory[indexOfItem].GetName() + "] Num Objects [" + Inventory[indexOfItem].GetNumItems() +"]");
            
        }

        

        UnityEngine.Object.Destroy(collision.gameObject);
        }
        // if(collision.gameObject.name.Contains("orangecrab"))        
        // {
            
        // Destroy(collision.gameObject);
        // //button.gameObject.SetActive(false);
         
        // } else if (collision.gameObject.name.Contains("barrenCoconutTree")){
            
        //     //Vector3 CavemanPos = Caveman.transform.position;
        //     //Vector3 pos = button.transform.position;
        //     //CavemanPos.x = 10f;
        //     //button.transform.position = CavemanPos;
        //     //button.gameObject.SetActive(true);

        // } else if (collision.gameObject.name.Contains("trex")){
            
        //     //Destroy(collision.gameObject);
        //     //button.gameObject.SetActive(false);
        // } else if (collision.gameObject.name.Contains("coconut")){
            
        //     Destroy(collision.gameObject);
        //     //button.gameObject.SetActive(false);
        // }
    }
}
