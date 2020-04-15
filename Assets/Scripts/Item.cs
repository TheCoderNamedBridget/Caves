using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
    [SerializeField]
    private GameObject item;
    private int numItems;

    private string nameOfItems;

    public Item ( string nameOfObject)
    {
        nameOfItems = nameOfObject;
    }

    public string GetName ()
    {
        return nameOfItems;
        
    }

    public void AddItem ()
    {
        numItems += 1;
    }

    public void SubtractItem ()
    {
        numItems -= 1;
    }

    public int GetNumItems ()
    {
        return numItems;
    }

    public void DisplayImageAndNumber()
    {

    }

}
