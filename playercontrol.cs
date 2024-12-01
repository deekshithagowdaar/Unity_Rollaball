using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;



public class playercontrol : MonoBehaviour
{
    private Rigidbody rd; 
    private float movementX;
    private float movementY;
    public float speed = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMove(InputValue movementValue) {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }
     private void FixedUpdate()
    {
        Vector3 movement= new Vector3(movementX, 0.0f , movementY);
        rd.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("pickup"))
        {
            other.gameObject.SetActive(false);
        }
    }

}
