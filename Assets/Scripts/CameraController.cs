using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    // Public so we can assign the player to this variable in the inspector
    public GameObject player;

    // Empty Vector3 to store the starting position of the camera
    Vector3 offset;

	// Use this for initialization
	void Start ()
    {
        offset = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
