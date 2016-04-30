using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = 800.0f;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }


    // When the ball enters a trigger collider
    void OnTriggerEnter(Collider other)
    {
        // When the object that was entered has the the powerup
        if(other.gameObject.tag == "PowerUp")
        {
            // Then set that object to be inactive
            other.gameObject.SetActive(false);
        }
    }
}
