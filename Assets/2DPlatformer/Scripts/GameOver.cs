using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
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
    public void Reiniciar()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase1");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
