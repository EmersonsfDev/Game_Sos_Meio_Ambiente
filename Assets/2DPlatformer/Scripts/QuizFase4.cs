using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizFase4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Perdeu4()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOverFase4");
    }
    public void PassarDeFase4()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SelecionarFase");
    }
}
