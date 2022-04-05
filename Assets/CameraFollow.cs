using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerClark;
    public float cameraDistance = 30f;
    // Set default value for cameraDistance, but also editable in the Unity UI

    void Awake()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameraDistance);    
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(playerClark.position.x, playerClark.position.y, transform.position.z);
    }

}
