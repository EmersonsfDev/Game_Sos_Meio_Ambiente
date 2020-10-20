using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverFase3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
    public void ReiniciarFase3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase3");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
