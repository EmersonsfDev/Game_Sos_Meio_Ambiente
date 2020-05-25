using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject PainelPause;
    public GameObject Jogador;
     private bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void Fechar(){
        PainelPause.SetActive(false);
        isPaused = false;
        Jogador.GetComponent<PlayerControl>().enabled = true;
	 }
    public void Menu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
    public void Exit()
    {
        Application.Quit();
    }
  
}
