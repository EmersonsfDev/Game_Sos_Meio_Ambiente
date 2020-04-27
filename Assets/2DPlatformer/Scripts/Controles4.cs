using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenFase4()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase4");
    }
    public void VoltarSelecionar ()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Controles");
    }
    
}
