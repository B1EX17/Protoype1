using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float turnSpeed = 45.0f;
    private float speed = 20.0f;
    private float horizontalInput;
    private float forwardInput;
    public Camera mainCamera; 
    public Camera hoodCamera; 
    public KeyCode switchKey;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Roatates the car based on horizonal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        if (Input.GetKeyDown(switchKey))
        { 
          mainCamera.enabled = !mainCamera.enabled;
          hoodCamera.enabled = !hoodCamera.enabled; 
        }

    }   
}
