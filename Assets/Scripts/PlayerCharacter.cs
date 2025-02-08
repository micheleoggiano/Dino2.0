using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


public class PlayerCharacter : MonoBehaviour
{
    public float maxSpeed = 6f;
    public Vector2 direction;
    public float jumpHeight = 3f;

    // Creo booleano per isGrounded
    bool isGrounded = true;

    // Crea referenza Rigidbody2D:
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }
    OnCollisionExit
    // Update is called once per frame
    void Update()
    {
    // Run (GetKeyDown and GetKeyUp)
        if (Input.GetKeyDown(KeyCode.LeftShift))
            maxSpeed = maxSpeed * 2f;

       if (Input.GetKeyUp(KeyCode.LeftShift))
            maxSpeed = 6f;

        // Player Movement WASD con GetAxis:

        float x;
        float y;

        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        direction = new Vector2(x, y);

        transform.position += maxSpeed * Time.deltaTime * (Vector3)direction;

        // Capacità di salto:
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            jumpVelocity = Mathf.Sqrt(2f * Phisics2D.gravity.magnitude * rb.gravityScale * jumpHeight);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = Vector2.up * jumpHeight;
            }

            isGrounded = false;
        }


    // Player movement WASD con "GetKey":
        //if (Input.GetKey(KeyCode.W))
        //    transform.position += Vector3.up * maxSpeed * Time.deltaTime;

        //if (Input.GetKey(KeyCode.S))
        //    transform.position += -Vector3.up * maxSpeed * Time.deltaTime;

        //if (Input.GetKey(KeyCode.D))
        //    transform.position += Vector3.right * maxSpeed * Time.deltaTime;

        //if (Input.GetKey(KeyCode.A))
        //    transform.position += -Vector3.right * maxSpeed * Time.deltaTime;

        
            
    }
}
