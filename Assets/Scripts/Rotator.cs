using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	// This function is for rotation of the cube
	void Update ()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}
}
