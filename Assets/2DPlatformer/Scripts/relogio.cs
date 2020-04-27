using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class relogio : MonoBehaviour
{
    public float tempo = 300.0f;
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( tempo > 0) {
            tempo -= Time.deltaTime;

        }
        else if(tempo < 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        }
        txt.text = tempo.ToString("0");    
    }
}
