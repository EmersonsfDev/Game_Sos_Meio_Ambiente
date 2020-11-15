using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizFase3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Perdeu3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOverFase3");
    }
    public void PassarDeFase3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SelecionarFase");
    }
}
