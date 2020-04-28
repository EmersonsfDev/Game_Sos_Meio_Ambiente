using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PainelPause;
    public GameObject BotaoPause;
    public bool isPaused;
     public GameObject Jogador;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {   
         Jogador = GameObject.FindWithTag ("Player");
    }
    public void Pause(){
        
        if(isPaused){
            PainelPause.SetActive(false);
            isPaused = false;
            Jogador.GetComponent<PlayerControl>().enabled = true;  
        }
        else{
            PainelPause.SetActive(true); 
            isPaused = true;
            Jogador.GetComponent<PlayerControl>().enabled = false;
        }
    }


}
