using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineColliderEnabler : MonoBehaviour
{

    BoxCollider2D lineCollider;
    // Start is called before the first frame update
    void Start()
    {
        lineCollider = this.GetComponent<BoxCollider2D>();
        lineCollider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Choque");
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Choca el jugador");
            //Disable the line collider
            lineCollider.enabled = false;



        }
    }
}
