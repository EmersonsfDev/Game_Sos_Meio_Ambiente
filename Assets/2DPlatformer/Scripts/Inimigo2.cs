using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Inimigo2 : MonoBehaviour
{
    private bool colide = false;
    private int move = -3;
    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {    
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(move, GetComponent<Rigidbody2D>().velocity.y);
        if (colide)
        {
            Flip();
        }
    }
    private void Flip()
    {
        move *= -1;
        GetComponent<SpriteRenderer>().flipX = !GetComponent<SpriteRenderer>().flipX;
        colide = false;
    }

       void OnTriggerEnter2D(Collider2D other)
    {
        
         if (other.gameObject.CompareTag("volta")||other.gameObject.CompareTag("Player"))
        {
            colide = true;
        }
    }
     void OnTriggerExit2D(Collider2D other)
    {
         if (other.gameObject.CompareTag("volta")||other.gameObject.CompareTag("Player"))
         {
            colide = false;;
         }
    }
   
}
