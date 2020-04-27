using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizFase1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Perdeu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
    }
    public void PassarDeFase()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SelecionarFase");
    }
}
