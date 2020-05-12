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
    public GameObject kauan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void OpenPainel2(){
      
       painelDoLixo.SetActive(false);
       painelDoLixo2.SetActive(true);

   }
    public void OpenPainel3(){
       painelDoLixo.SetActive(false);
       painelDoLixo2.SetActive(false);
       painelDoLixo3.SetActive(true);
   }
    public void OpenPainel4(){
       painelDoLixo.SetActive(false);
       painelDoLixo2.SetActive(false);
       painelDoLixo3.SetActive(false);
       painelDoLixo4.SetActive(true);
   }
    public void OpenPainel5(){

       painelDoLixo.SetActive(false);
       painelDoLixo2.SetActive(false);
       painelDoLixo3.SetActive(false);
       painelDoLixo4.SetActive(false);  
       painelDoLixo5.SetActive(true);
   }
   public void ClosePainel(){
      
       painelDoLixo5.SetActive(false);
   }
    public void RespostaErrada(){
       painelDoLixo2.SetActive(false);
       painelDoLixo3.SetActive(false);
       painelDoLixo4.SetActive(false);  
       painelDoLixo5.SetActive(false);
       painelDoLixo.SetActive(true);
   }

}
