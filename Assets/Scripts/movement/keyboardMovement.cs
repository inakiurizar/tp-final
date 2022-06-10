using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardMovement : MonoBehaviour
{
    public float speed = 0.2f;
    Vector3 move;
    public CharacterController controller;
    float x, z;
    public float gravity = -9.81f;
    public float JumpHeight = 3f;

    //bool isGrounded;
    //public Transform groundCheck;
    //public float groundDistance;
    //public LayerMask groundMask;

    void Update()
    {
        //isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        //if (isGrounded && velocity.y < 0)
        //{
        //    velocity.y = -2f;
        //}

        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed);

        //if (Input.GetButtonDown("Jump") && isGrounded)
        //{
        //    velocity.y = Mathf.Sqrt(JumpHeight * -2f * gravity);
        //}

        //velocity.y = gravity;

        //controller.Move(velocity);
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * JumpHeight, ForceMode.Impulse);

        }
    }
    void OnCollisionEnter(Collision C)
    {
        if(C.gameObject.tag == "???")
        {
            
        }
    }
}
