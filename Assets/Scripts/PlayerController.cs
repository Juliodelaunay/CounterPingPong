using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 8f;
    private float force = 10f;
    private float iV;
    private float iH;
    private Transform aimTarget;
    private bool hitBall;
    private Rigidbody rbBall;
    private Animator playerAnim;
    public AudioSource audioSource;
    static public bool response;
    
    

   void Start()
{
    aimTarget=GameObject.Find("AimTarget").GetComponent<Transform>();
    playerAnim = GameObject.Find("Palet").GetComponent<Animator>();
    response=false;
}

private void Update()
{   
    Move();
    
}

    private void Move()
{
    iV=Input.GetAxisRaw("Horizontal");
    iH=Input.GetAxisRaw("Vertical");
   
    transform.Translate(new Vector3 (iV,iH,0f) * speed *  Time.deltaTime);
    
    if (transform.position.z > 0.60f)
    { transform.position = new Vector3 (transform.position.x,transform.position.y,0.60f);}
    if (transform.position.z < -3.60f)
    {transform.position = new Vector3 (transform.position.x,transform.position.y,-3.60f);}
     if (transform.position.x < -4f)
    {transform.position = new Vector3 (-4f,transform.position.y,transform.position.z);}
    if (transform.position.x > -1f)
    {transform.position = new Vector3 (-1f,transform.position.y,transform.position.z);}
}

   
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball"))
        {   
            playerAnim.Play("Player Hit Animation") ;
            Vector3 dir = (aimTarget.position - transform.position);
            other.GetComponent<Rigidbody>().velocity = dir.normalized * force + new Vector3(0,5,0);
            audioSource.Play();
            response=true;
            
        }
    }
    
    private void OnTriggerExit(Collider other)
    { if(other.CompareTag("Ball"))
    
     {
      response=false;
     }
        
    }

    








}




