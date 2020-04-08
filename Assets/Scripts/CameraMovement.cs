using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    
    
    public Transform player;

    public float smoothSpeed = 0.0125f;

    public float cameraDistance = 30f;

    public int xOffset;

    public int yOffset;


    void Awake ()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameraDistance);
    }
    void LateUpdate ()
    {
        transform.position = new Vector3( player.position.x + xOffset, player.position.y + yOffset, transform.position.z);
    }
}
