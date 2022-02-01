using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
   private Vector3 initPosition;
   private Rigidbody rbBall;
   private int collision;
   private TrailRenderer trail;
  
   

    void Start()
    {
        initPosition=transform.position;
        rbBall=gameObject.GetComponent<Rigidbody>();
        rbBall.velocity = Vector3.up * 5f + new Vector3 (5,0,0);
        rbBall.AddForce(Vector3.right *  15 *Time.deltaTime * 10f );
        trail=GetComponent<TrailRenderer>();
    }

    
    void Update()
    {  
        if(PlayerController.response==true)
        {
            trail.enabled=true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Sensor"))
        {
            Destroy(gameObject,2f);
        }
         if(other.CompareTag("Sensor2"))
        {
            Destroy(gameObject,2f);
        }
    }
  
}

