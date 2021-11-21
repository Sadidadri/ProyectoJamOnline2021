using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ComportamientoBotones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartButtonClick(){
        SceneManager.LoadScene("SampleScene");
    }

    public void OnRetryButtonClick(){
        Debug.Log("Retry pulsado");
      SceneManager.LoadScene("SampleScene");
      Time.timeScale = 1;
      AudioListener.pause = false;
   }

   public void OnBackMenuButtonClick(){
      SceneManager.LoadScene("Menu");
   }

   public void OnCreditsButtonClick(){
      SceneManager.LoadScene("Credits");
   }

   public void closeGameClick(){
       Application.Quit();
   }
}
