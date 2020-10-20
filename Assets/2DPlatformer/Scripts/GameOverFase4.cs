using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverFase4 : MonoBehaviour
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
    public void ReiniciarFase4()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase4");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
