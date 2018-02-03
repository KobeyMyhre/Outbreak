using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    PlayerController controller;
    
    Rigidbody rb;
    public float speed;
    public float lookSpeed;

	// Use this for initialization
	void Start ()
    {
        
        rb = GetComponent<Rigidbody>();
        controller = GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 moveDir = new Vector3(controller.moveX, 0, controller.moveZ) * -speed;
        rb.AddForce(moveDir - rb.velocity, ForceMode.VelocityChange);

        Vector3 desiredRot = new Vector3(transform.position.x - controller.lookX, transform.position.y, transform.position.z - controller.lookZ);
        Vector3 lookRot = -(transform.position - desiredRot).normalized;
        if(lookRot != Vector3.zero)
        {
            transform.forward = Vector3.Slerp(transform.forward, lookRot, lookSpeed * speed);
        }
       

        

	}
}
