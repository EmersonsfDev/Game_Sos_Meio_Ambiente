using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Inimigo1 : MonoBehaviour
{

    public SliderJoint2D slider;
    public JointMotor2D aux;

    // Use this for initialization
   void Start()
    {    
        aux = slider.motor;
    }

    // Update is called once per frame
    void Update()
    {
    
        if(slider.limitState == JointLimitState2D.LowerLimit){
            aux.motorSpeed = 1;
            slider.motor = aux;
        }
        if(slider.limitState == JointLimitState2D.UpperLimit){
            aux.motorSpeed = -1;
            slider.motor = aux;
        }     
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
            transform.Rotate(new Vector3(0, 0, -180));
            Destroy(gameObject, 0.1f);
        } 
    }
    }

