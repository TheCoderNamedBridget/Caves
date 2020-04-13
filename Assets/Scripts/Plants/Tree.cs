using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
Tree Class: Contro;s tree grown, behavior, and actionable items
Tree:
1.be chopped
2.produce fruit object
3.grow back after being chopped
    drop wood and fruit when chopped
4.drop fruit objects when hit or kicked
*/
public class Tree : MonoBehaviour
{
    [SerializeField]
    private GameObject tree;
    [SerializeField]
    private GameObject fruit;

    [SerializeField]
    private int numberOfFruit;


    float timeLeft = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        timeLeft -= Time.deltaTime;

        if(timeLeft < 0)
        {
            //Debug.Log("Time is up");

            if ( numberOfFruit < 4)
            {
                ProduceFruit();
            }
            timeLeft = 20f;
        }
    }

    void ProduceFruit()
    {
        numberOfFruit += 1;
        GameObject newFruit = Instantiate( fruit );
        newFruit.transform.position = new Vector3(tree.transform.position.x - 2, tree.transform.position.y);
    }


}
