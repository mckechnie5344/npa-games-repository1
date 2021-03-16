using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Public Variables
    public float movementForce = 10f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Condition When the player presses a button
        if (Input.GetKey(KeyCode.D) == true)
        {
            // Action:Apply a force (move the player)

            // Get the rigidbody componet off our player so
            // we use it
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

            // add a force to the rigidbody to move player
            ourRigidbody.AddForce(Vector2.right * movementForce);
        }
        if (Input.GetKey(KeyCode.A) == true)
        {
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

            ourRigidbody.AddForce(Vector2.left * movementForce);
        }

        if (Input.GetKey(KeyCode.S) == true)
        { 
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

            ourRigidbody.AddForce(Vector2.down * movementForce);
        }

        if (Input.GetKey(KeyCode.W) == true)
        { 
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

            ourRigidbody.AddForce(Vector2.up * movementForce);
        }

    }
}