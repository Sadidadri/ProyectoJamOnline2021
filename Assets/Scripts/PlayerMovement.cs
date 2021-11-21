using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Reference to Sprite Renderer component
    private Renderer rend;
    private Color color1Golpe = new Color(150f/255f, 150f/255f, 150f/255f);
    private Color color2Golpe = new Color(80f/255f, 80f/255f, 80f/255f);
    private Color color3GolpesMuelte = new Color(32f/255f, 32f/255f, 32f/255f);
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
        rend = GetComponent<Renderer>();

    }

    void Update(){
        switch (PlayerCounters.lifes)
        {
            case 3: //Nada
                break;
            case 2: //1 vida menos
                rend.material.color = color1Golpe;
                break;
            case 1: //2 vidas menos
                rend.material.color = color2Golpe;
                break;
            default: //Muelto
                rend.material.color = color3GolpesMuelte;
                break;
        }
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
