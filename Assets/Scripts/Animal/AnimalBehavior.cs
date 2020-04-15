using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBehavior : MonoBehaviour
{

    [SerializeField]
    private GameObject animal;

    [SerializeField]
    private GameObject poop;

    private int numberOfPoops;
    float timeLeft = 2.0f;

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

            if ( numberOfPoops < 20)
            {
                StartToPoop();
            }
            timeLeft = 5f;
        }
    }

    void Poop()
    {
        numberOfPoops += 1;
        GameObject newPoop = Instantiate( poop );
        newPoop.transform.position = new Vector3(animal.transform.position.x + 4, animal.transform.position.y - 2);
    }

    void StartToPoop ()
    {
        Debug.Log("insie start to poop ");
        // Animator animator = animal.GetComponent<Animator>();
        // animator.runtimeAnimatorController = Resources.Load("greentrexshitting1") as RuntimeAnimatorController;
        Poop();
    }
}
