using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter2 : MonoBehaviour
{
    private Text CounterText;
    
   
   
    private void Start()
    
    {   
        CounterText=GameObject.Find("Text").GetComponent<Text>();
    }

   
    private void OnTriggerEnter(Collider other)
    {  
      // GameManager.Count -= 1;
       // CounterText.text = "Count : " + GameManager.Count;

       GameManager.gameIsActive=false;
    }
}