using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    private Vector3 spwan;
    private float xPos;
    public GameObject Ball;
    public ParticleSystem dust;
    private float minTime=2f;
    public AudioSource audioSource;
    
    
    void Start()
    {
       StartCoroutine (reSpawn());
       StartCoroutine (nivel());
    }

    IEnumerator reSpawn()

    {  xPos=UnityEngine.Random.Range(-3.5f,0.5f);
       transform.position = new Vector3(-7.5f,2.3f,xPos);
       Instantiate(Ball,transform.position,transform.rotation);
       yield return new WaitForSeconds(minTime);
       audioSource.Play();
       dust.Play();
       
       StartCoroutine (reSpawn());
    }

    IEnumerator nivel()
    {  minTime -=0.1f;
       yield return new WaitForSeconds(3);
       StartCoroutine (nivel());
    }
    
   

}
