using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HudController : MonoBehaviour
{
    [SerializeField] private GameObject buttonPause;
    [SerializeField] private GameObject menuPause;
    [SerializeField] private GameObject gameOver;
    [SerializeField] private GameObject buttonResume;
    


    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Escape) )
        
        {
            gameOver.SetActive(false);
            Pause();
        }
    
        if (GameManager.gameIsActive==false)
        {   
            Time.timeScale=0;
            gameOver.SetActive(true);
            GameManager.gameIsActive=true;
            buttonResume.SetActive(false);
           
           
        }    
    
    
    
    }



    public void Pause() 
    {
        Time.timeScale=0;
         //if (Input.GetKeyDown(KeyCode.F1))
        menuPause.SetActive(true);
        gameOver.SetActive(false);

    }

    public void Resume()
    {   
        Time.timeScale=1;
        //buttonPause.SetActive(true);
        menuPause.SetActive(false);
    }

    public void Restart() 
    {   GameManager.gameIsActive=true;
        Time.timeScale=1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit() 
    {
        Application.Quit();
    }
    


}
