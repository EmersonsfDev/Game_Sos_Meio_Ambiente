using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fase : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenControles()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Controles");
    }
    public void OpenFase2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Controles2");
    }
    public void OpenFase3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Controles3");
    }
    public void OpenControles4()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Controles4");
    }
    public void OpenFase5()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Controles5");
    }

}
