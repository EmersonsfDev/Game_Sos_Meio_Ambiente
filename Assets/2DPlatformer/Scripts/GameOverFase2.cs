using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverFase2 : MonoBehaviour
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
    public void ReiniciarFase2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase2");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
