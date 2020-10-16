using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Player_Input : MonoBehaviour
{
    public float maxJumpTime = 0.75f;
    float gravity = 0;
    public float gravityScale = -9.8f;
    Vector3 movement;
    public float speed = 10f;
    CharacterController controller;
    public float jumpHeight = 2f;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        movement.x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        movement.z = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;


        controller.Move(movement);
        
        

    }

    

    
}
