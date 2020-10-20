using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenFase2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase2");
    }
    public void VoltarSelecionar ()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SelecionarFase");
    }
    
}
