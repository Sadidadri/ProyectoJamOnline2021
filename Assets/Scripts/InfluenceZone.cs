using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfluenceZone : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision){


            Debug.Log("Entre en la linea");
            PlayerMovement.rb2d.gravityScale = 0;
            PlayerMovement.isGrounded = true;   

    }
    
    private void OnTriggerExit2D(Collider2D collision){

            Debug.Log("Sali de la linea");
        PlayerMovement.rb2d.gravityScale = 1;
           PlayerMovement.isGrounded = false;   

    }
}
