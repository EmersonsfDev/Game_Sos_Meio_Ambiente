using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class FF : MonoBehaviour
{
    
    public AudioClip ffSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision2d)
    {
        if (collision2d.gameObject.CompareTag("Player")){
           // Gerenciador.inst.PlayAudio(ffSound);
          GetComponent<AudioSource> ().PlayOneShot (ffSound);
	    }
    }
}
