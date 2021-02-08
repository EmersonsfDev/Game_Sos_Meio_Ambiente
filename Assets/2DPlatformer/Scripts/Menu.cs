using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenSelecionarFase()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SelecionarFase");
    }
     public void OpenCreditos()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Creditos");
    }
     public void OpenMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
