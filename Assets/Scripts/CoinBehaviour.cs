using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{

    public AudioSource audioSource;
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
            audioSource.Play();
            PlayerCounters.points += 5;

            Destroy(gameObject);
        }

    }

}
