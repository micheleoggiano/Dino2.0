using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


public class PlayerCharacter : MonoBehaviour
{
public float maxSpeed = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    // Run (GetKeyDown and GetKeyUp)
        if (Input.GetKeyDown(KeyCode.LeftShift))
            maxSpeed = maxSpeed * 2f;

       if (Input.GetKeyUp(KeyCode.LeftShift))
            maxSpeed = 2f;

    // Player movement WASD:
        if (Input.GetKey(KeyCode.W))
            transform.position += Vector3.up * maxSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.S))
            transform.position += -Vector3.up * maxSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            transform.position += Vector3.right * maxSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            transform.position += -Vector3.right * maxSpeed * Time.deltaTime;

        
            
    }
}
