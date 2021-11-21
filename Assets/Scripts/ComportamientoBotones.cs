using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ComportamientoBotones : MonoBehaviour
{
    public AudioSource sonidoClick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartButtonClick(){
        sonidoClick.Play();
        SceneManager.LoadScene("SampleScene");
    }

    public void OnRetryButtonClick(){
        Time.timeScale = 1;
      //AudioListener.pause = false;
        sonidoClick.Play();
      SceneManager.LoadScene("SampleScene");
      Time.timeScale = 1;
      AudioListener.pause = false;
   }

   public void OnBackMenuButtonClick(){
       Time.timeScale = 1;
      //AudioListener.pause = false;
       sonidoClick.Play();
      SceneManager.LoadScene("Menu");
      
   }

   public void OnCreditsButtonClick(){
       sonidoClick.Play();
      SceneManager.LoadScene("Credits");
   }

   public void closeGameClick(){
       Application.Quit();
   }
}
