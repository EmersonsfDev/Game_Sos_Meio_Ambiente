using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paineldolixo : MonoBehaviour
{
    public GameObject painelDoLixo;
    public GameObject painelDoLixo2;
    public GameObject painelDoLixo3;
    public GameObject painelDoLixo4;
    public GameObject painelDoLixo5;
    public GameObject painelDoLixo6;
   
    public AudioClip frase1;
    public AudioClip frase2;
    public GameObject kauan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  public void close1(){
       GetComponent<AudioSource> ().PlayOneShot (frase1);
       painelDoLixo.SetActive(false);
     FindObjectOfType<PlayerControl>().speed = 7;
     
       
   }
     public void close2(){
       GetComponent<AudioSource> ().PlayOneShot (frase1);
       painelDoLixo2.SetActive(false);
       FindObjectOfType<PlayerControl>().speed = 7;
       
   }
     public void close3(){
       GetComponent<AudioSource> ().PlayOneShot (frase1);
       painelDoLixo3.SetActive(false);
       
   }
     public void close4(){
       GetComponent<AudioSource> ().PlayOneShot (frase1);
       painelDoLixo4.SetActive(false);
        FindObjectOfType<PlayerControl>().speed = 7;
   }
   

   public void OpenPainel2(){
       GetComponent<AudioSource> ().PlayOneShot (frase1);
       painelDoLixo.SetActive(false);
       painelDoLixo2.SetActive(true);

   }
    public void OpenPainel3(){
    GetComponent<AudioSource> ().PlayOneShot (frase1);
       painelDoLixo.SetActive(false);
       painelDoLixo2.SetActive(false);
       painelDoLixo3.SetActive(true);
   }
    public void OpenPainel4(){
    GetComponent<AudioSource> ().PlayOneShot (frase1);
       painelDoLixo.SetActive(false);
       painelDoLixo2.SetActive(false);
       painelDoLixo3.SetActive(false);
       painelDoLixo4.SetActive(true);
   }
    public void OpenPainel5(){
        GetComponent<AudioSource> ().PlayOneShot (frase1);
       painelDoLixo.SetActive(false);
       painelDoLixo2.SetActive(false);
       painelDoLixo3.SetActive(false);
       painelDoLixo4.SetActive(false);  
       painelDoLixo5.SetActive(true);
   }
   public void ClosePainel(){
      
      UnityEngine.SceneManagement.SceneManager.LoadScene("SelecionarFase");
   }
  
     public void ClosePainel2(){
      painelDoLixo.SetActive(false);
       painelDoLixo2.SetActive(false);
       painelDoLixo3.SetActive(false);
       painelDoLixo4.SetActive(false);  
       painelDoLixo5.SetActive(false);

      
   }

    public void RespostaErrada(){
    GetComponent<AudioSource> ().PlayOneShot (frase2);
       painelDoLixo2.SetActive(false);
       painelDoLixo3.SetActive(false);
       painelDoLixo4.SetActive(false);  
       painelDoLixo5.SetActive(false);
       painelDoLixo.SetActive(true);
       
   }

}
