using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Inimigo : MonoBehaviour
{
    private bool colide = false;
    private int move = -2;
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
        if (other.gameObject.CompareTag("Player"))
        {
            BoxCollider2D[] boxes = gameObject.GetComponents<BoxCollider2D>();
            foreach(BoxCollider2D box in boxes)
            {
                box.enabled = false;
            }

            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 200));

            move = 0;
            transform.Rotate(new Vector3(0, 0, -180));
            Destroy(gameObject, 0.5f);
        }
         if (other.gameObject.CompareTag("volta"))
        {
            colide = true;
        }
    }
     void OnTriggerExit2D(Collider2D other)
    {
         if (other.gameObject.CompareTag("volta"))
         {
            colide = false;;
         }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("plataforma")||collision.gameObject.CompareTag("escorpiao") || collision.gameObject.CompareTag("rato")
         || collision.gameObject.CompareTag("mosca") || collision.gameObject.CompareTag("barata"))
        {
            colide = true;
        }
       
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("plataforma")||collision.gameObject.CompareTag("escorpiao") || collision.gameObject.CompareTag("rato")
        || collision.gameObject.CompareTag("mosca") || collision.gameObject.CompareTag("barata"))
        {
            colide = false;
        }
    }
}
