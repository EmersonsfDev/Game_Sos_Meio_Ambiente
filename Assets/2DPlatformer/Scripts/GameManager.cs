using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
 
    public GameObject Jogador;
    public GameObject PainelPause;
    private bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    void Update()
    {
      if(Input.GetKeyDown(KeyCode.P))
      {
      if(!isPaused){
            PainelPause.SetActive(true); 
            isPaused = true;
            Jogador.GetComponent<PlayerControl>().enabled = false;
      }

        else if(isPaused){
            PainelPause.SetActive(false);
            isPaused = false;
            Jogador.GetComponent<PlayerControl>().enabled = true; 
        }
      }
     }
}
