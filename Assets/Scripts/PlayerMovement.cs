using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static string jumpDirection = "static";
    public static bool isGrounded;
    public static Rigidbody2D rb2d;
    public float jumpForce = 250;


    public GameObject bottomLine;
    public GameObject topLine;

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
        rb2d.AddForce(Vector2.up * jumpForce);
        jumpDirection = "up";
        //Obtain bottom collider line and enable it
        bottomLine.GetComponent<BoxCollider2D>().enabled = true;

    }
    private void JumpDown(){
        rb2d.AddForce(Vector2.up * -jumpForce);
        jumpDirection = "down";
        //Obtain top collider line and enable it
        topLine.GetComponent<BoxCollider2D>().enabled = true;
    }
}
