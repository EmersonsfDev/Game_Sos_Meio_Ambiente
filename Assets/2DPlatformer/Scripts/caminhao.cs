using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class caminhao : MonoBehaviour
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

   }   
   
   void OnTriggerEnter2D(Collider2D other)
   {
            if (other.gameObject.CompareTag("Player"))
            {
               if(slider.limitState == JointLimitState2D.UpperLimit){
                    aux.motorSpeed = -2;
                    slider.motor = aux;
               }  
            } 
   }
}

 

