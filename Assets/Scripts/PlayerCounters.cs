using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCounters : MonoBehaviour
{
    public static int lifes;
    public static double points;
    public TextMeshProUGUI score;

    // Start is called before the first frame update
    void Start()
    {
            
        lifes = 3;
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Game over
        if (lifes <= 0) {
            Debug.Log("Game Over");
        }
        //Add points
        points += 0.01;

        score.SetText("Score: "+ Mathf.FloorToInt((float)points)); 
    }
}
