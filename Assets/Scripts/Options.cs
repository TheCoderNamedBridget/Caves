using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{

    GameObject UItoDisable;
    // Start is called before the first frame update
    void Start()
    {
        //button = GameObject.Find("Button");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick(){
		Debug.Log("click registered");
        //button.gameObject.SetActive(true);
        UItoDisable.GetComponent<CanvasGroup>().alpha = 0;
	}

    
}


