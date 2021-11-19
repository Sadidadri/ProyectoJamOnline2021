using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static bool isGrounded;
    public static Rigidbody2D rb2d;
    public float jumpSpeed = 3;

    void Start(){
        isGrounded = true;
        rb2d = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate(){
        if ((Input.GetKey("up") || Input.GetKey("w")) && isGrounded){
            JumpUp();
        }
        else if ((Input.GetKey("down") || Input.GetKey("s")) && isGrounded){
            JumpDown();
        }
    }

    private void JumpUp(){
        rb2d.AddForce(Vector2.up * jumpSpeed);
    }
    private void JumpDown(){
        rb2d.AddForce(Vector2.up * -jumpSpeed);
    }
}
