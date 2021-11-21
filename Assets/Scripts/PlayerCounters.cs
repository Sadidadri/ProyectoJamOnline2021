using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCounters : MonoBehaviour
{
    public AudioSource levelMusic;
    public AudioSource derrotaSound;
    public static bool winEventSuccess = false;
    public GameObject WinMenu;
    bool gameFinished = false;
    public static int lifes;
    public static double points;
    public TextMeshProUGUI score;
    public TextMeshProUGUI finalScore;

    public GameObject gameOverMenu;

    // Start is called before the first frame update
    void Start()
    {
        gameOverMenu.SetActive(false);
        WinMenu.SetActive(false);
        lifes = 3;
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Game over
        if (lifes <= 0 && !gameFinished) {
            levelMusic.Stop();

            
            derrotaSound.Play();
            string finalPoints = "Score: "+ Mathf.FloorToInt((float)points);
            finalScore.SetText("Score: "+ Mathf.FloorToInt((float)points)); 
            gameOverMenu.SetActive(true);
            Destroy(score);
            gameFinished = true;
            Time.timeScale = 0;
            //Debug.Log("Game Over");
        }
        //WIN
        if (!gameFinished && winEventSuccess){
            levelMusic.Stop();

            
            string finalPoints = "Score: "+ Mathf.FloorToInt((float)points);
            finalScore.SetText("Score: "+ Mathf.FloorToInt((float)points)); 
            WinMenu.SetActive(true);
            Destroy(score);
            gameFinished = true;
            Time.timeScale = 0;
        }
        /*

        */
        //Add points
        points += 0.01;

        score.SetText("Score: "+ Mathf.FloorToInt((float)points)); 
    }
}
