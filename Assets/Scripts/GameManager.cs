using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static int Count=0;
    public static float increase=0.2f;
    public static GameManager instance;
    public static bool gameIsActive = true;
    public GameObject spawn;
    public AudioSource audioSource;
    
   
     private void Awake()
    {
        if (instance == null)
        { instance = this; 
        DontDestroyOnLoad(gameObject);}
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {   
       

              
        
        if (gameIsActive==false)
        {   
            Debug.Log("Game Over");
            
        }
      
    }
    
}

   

    
