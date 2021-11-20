using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public AudioSource audioSource;
    public static string jumpDirection = "static";
    public static bool isGrounded;
    public static Rigidbody2D rb2d;
    public float jumpForce = 300;


    public GameObject bottomLine;
    private BoxCollider2D bottomLineCollider;
    public GameObject centralLine;
    public GameObject topLine;
    private BoxCollider2D topLineCollider;

    void Start(){
        isGrounded = true;
        rb2d = GetComponent<Rigidbody2D>();
        //Obtain bottom collider line and enable it
        bottomLineCollider = bottomLine.GetComponent<BoxCollider2D>();
        topLineCollider = topLine.GetComponent<BoxCollider2D>();
    }


    void FixedUpdate(){
        //Encima de la linea del medio
        if (transform.position.y >= centralLine.transform.position.y + 0.2){
            bottomLineCollider.enabled = true;
        }
        if (transform.position.y <= centralLine.transform.position.y - 0.2){
            topLineCollider.enabled = true;
        }

        if ((Input.GetKey("up") || Input.GetKey("w")) && isGrounded){
            JumpUp();
        }
        else if ((Input.GetKey("down") || Input.GetKey("s")) && isGrounded){
            JumpDown();
        }
    }

    private void JumpUp(){
        audioSource.Play();
        rb2d.AddForce(Vector2.up * jumpForce);
        jumpDirection = "up";
        

    }
    private void JumpDown(){
        audioSource.Play();
        rb2d.AddForce(Vector2.up * -jumpForce);
        jumpDirection = "down";
        //Obtain top collider line and enable it
        topLine.GetComponent<BoxCollider2D>().enabled = true;
    }
}
