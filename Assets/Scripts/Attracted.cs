using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attracted : MonoBehaviour
{
     public GameObject attractedTo;
     private Rigidbody2D rb2d;
     public float strengthOfAttraction = 5.0f;
     void Start (){
         rb2d = GetComponent<Rigidbody2D>();
     }
     void Update()
     {
         Vector2 direction = new Vector2(0.0f,attractedTo.transform.position.y - transform.position.y);
         rb2d.AddForce(strengthOfAttraction * direction);
 
     }
}
