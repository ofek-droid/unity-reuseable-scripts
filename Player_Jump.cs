using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Jump : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject groundChecker;
    public float radius = 0.31f;
    public LayerMask whatIsGround;


    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    float jump = 8.0f;
    CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Physics.CheckSphere(groundChecker.transform.position, radius, whatIsGround))
        {
            if (Input.GetButton("Jump"))
            {
                Debug.Log("Hi");
                jump = jumpSpeed;
            }

        }
        jump -= gravity * Time.deltaTime;
        controller.Move(jump * Time.deltaTime * Vector3.up);
    }
}
