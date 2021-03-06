using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{

    public AudioSource sonidoGolpe;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //1 life less
        if (collision.gameObject.tag == "Player")
        {
            sonidoGolpe.Play();
            PlayerCounters.lifes -= 1;
            Debug.Log("Vidas: " + PlayerCounters.lifes);
        }
    }
}
