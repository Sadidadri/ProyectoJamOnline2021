using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButtons : MonoBehaviour
{

    Scene scene;
    void OnStart(){
        scene = SceneManager.GetActiveScene(); 

    }
    public void OnRetryButtonPress(){
      SceneManager.LoadScene("SampleScene");
      Time.timeScale = 1;
      AudioListener.pause = false;
   }
}
