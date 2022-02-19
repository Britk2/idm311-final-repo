using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;

    private Vector3 velocity;
    public float gravity = -9f;

    public Transform groundCheck;
    public float groundRadius = 0.4f;
    public LayerMask groundMask;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        

        //Vector3 directionC = new Vector3(x, 0f, z);
        Vector3 directionC = transform.right * x + transform.forward * z;

        controller.Move(directionC * speed * Time.deltaTime);

        isGrounded = Physics.CheckSphere(groundCheck.position, groundRadius, groundMask);

        if (isGrounded)
        {
            velocity.y = 0f;
        }
        else
        {
            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        }
    }
}
