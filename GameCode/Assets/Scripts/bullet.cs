using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Score score;
   // public GameObject hitEffect;


    private void Awake()
    {
        score = GameObject.FindGameObjectWithTag("Player").GetComponent<Score>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.gameObject.tag == "Enemy")
        {
           // GameObject effect =  Instantiate(hitEffect, collision.transform.position, collision.transform.rotation);
            Destroy(collision.gameObject);
            //Destroy(effect, 2f);
            Score.score += 10;
 
        }
        Destroy(gameObject);
        
      
    }

}
