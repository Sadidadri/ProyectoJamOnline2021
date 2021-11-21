using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muelte : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //GAME OVER
        if (collision.gameObject.tag == "Player")
        {
            PlayerCounters.lifes -= 5;
            Debug.Log("Vidas: " + PlayerCounters.lifes);
        }
    }
}
