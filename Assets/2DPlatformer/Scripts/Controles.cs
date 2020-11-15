using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenFase1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase1");
    }
    public void OpenFase2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase2");
    }
    public void OpenFase3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase3");
    }
    public void OpenFase4()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase4");
    }
    public void OpenFase5()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase5");
    }
    public void VoltarSelecionar ()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SelecionarFase");
    }
    
}
