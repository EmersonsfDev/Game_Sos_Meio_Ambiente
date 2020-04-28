using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject PainelPause;
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
