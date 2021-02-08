using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class PlayerControl : MonoBehaviour {

    public GameObject lastCheckpoint;
    public bool dead=false;
    public bool vivo=true;
    public bool VerificaContatoChao = true;
    public bool VerificaContatofase1 = false;
    public bool VerificaContatofase2 = false;
    public bool VerificaContatofase3 = false;
    public bool VerificaContatofase4 = false;
    public bool VerificaContatofase5 = false;
    public GameObject painelDoLixo;
    public GameObject painelDoLixo2;
    public GameObject painelDoLixo3;
    public GameObject painelDoLixo4;
    public GameObject painelDoLixo5;
    public GameObject painelDoLixo6;
    public GameObject c1;
     public GameObject c2;
      public GameObject c3;
       public GameObject c4;
        public GameObject c5;
         public GameObject c6;
          public GameObject c7;
          public GameObject c8;
     public GameObject rreduzir;
     public GameObject ereduzir;
     public GameObject dreduzir;      
     public GameObject ureduzir;
     public GameObject zreduzir;
     public GameObject ireduzir;
     public GameObject r2reduzir;

     public GameObject rreciclar;
     public GameObject ereciclar;
     public GameObject creciclar;
     public GameObject ireciclar;
     public GameObject c2reciclar;
     public GameObject lreciclar;
     public GameObject areciclar;
     public GameObject r2reciclar;

     public GameObject rreutilizar;
     public GameObject ereutilizar;
     public GameObject ureutilizar;
     public GameObject treutilizar;
     public GameObject ireutilizar;
     public GameObject lreutilizar;
     public GameObject i2reutilizar;
     public GameObject zreutilizar;
     public GameObject areutilizar;
     public GameObject r2reutilizar;
    

   

    public bool lixeira = false;
    public bool lixeira2 = false;
    public bool lixeira3 = false;
    public bool lixeira4 = false;
    public bool lixeira5 = false;

    public bool tutorial = false;
    public int pet = 0;
    public int organico = 0;
    public int vidro = 0;
    public int papel = 0;
    public int metal = 0;
    public int r3 = 0;
    public int vida = 5;
    public int pontuacao=0;
     public int a=0;
     public int b=0;
     public int c=0;
     public int d=0;
     public int e=0;
     public int f=0;
     public int g=0;
     public int h=0;
     public int painel=0;
    public int controle=0;
    public float tempo = 300.0f;
    public bool relogio= true;
    public Text txt;


    public bool fraseSound = true;
    public bool fraseSound2 = true;
    public bool fraseSound3 = true;
    public bool fraseSound4 = true;
    public bool fraseSound5 = true;
    public bool fraseSound6 = true;
    public bool fraseSound7 = true;
    public bool fraseSound8 = true;
    public bool fraseSound9 = true;
     public bool seilaSound = true;
      public bool seila2Sound = true;

    public bool fraseFase2Sound = true;
    public bool fraseFase2Sound2 = true;
    public bool fraseFase2Sound3 = true;
    public bool fraseFase2Sound4 = true;
    public bool fraseFase2Sound5 = true;
    public bool fraseFase2Sound6 = true;
    public bool fraseFase2Sound7 = true;
    public bool fraseFase2Sound8 = true;

    public bool fase3FraseSound = true;
    public bool fase3FraseSound2 = true;
    public bool fase3FraseSound3 = true;
    public bool fase3FraseSound4 = true;
    public bool fase3FraseSound5 = true;


    public bool fase4FraseSound = true;
    public bool fase4FraseSound2 = true;
    public bool fase4FraseSound3 = true;
    public bool fase4FraseSound4 = true;

    public bool fase5FraseSound = true;
    public bool fase5FraseSound2 = true;
    public bool fase5FraseSound3 = true;
    public bool fase5FraseSound4 = true;
    public bool fase5FraseSound5 = true;
    public bool fase5FraseSound6 = true;


    public Text TextPet;
    public Text TextOrganico;
    public Text TextVidro;
    public Text TextPapel;
    public Text TextMetal;
    public Text TextVida;
    public Text TextPontuacao;
    public Text TextR3;

    public float speed = 7f;
    public AudioClip jumpSound;
    public AudioClip coletSound;
    public AudioClip deathSound;
    public AudioClip deathS;
    public AudioClip frase;
    public AudioClip frase2;
    public AudioClip frase3;
    public AudioClip frase4;
    public AudioClip frase5;
    public AudioClip frase6;
    public AudioClip frase7;
    public AudioClip frase8;
    public AudioClip frase9;
    public AudioClip seila;
    public AudioClip seila2;

    public AudioClip fraseFase21;
    public AudioClip fraseFase22;
    public AudioClip fraseFase23;
    public AudioClip fraseFase24;
    public AudioClip fraseFase25;
    public AudioClip fraseFase26;
    public AudioClip fraseFase27;
    public AudioClip fraseFase28;
    
    public AudioClip Fase4Frase1;
    public AudioClip Fase4Frase2;
    public AudioClip Fase4Frase3;
     public AudioClip Fase4Frase4;

    public AudioClip frase1fase3;
    public AudioClip frase2fase3;
    public AudioClip frase3fase3;
     public AudioClip frase4fase3; 
     public AudioClip frase5fase3;

    public AudioClip frase1fase5;
    public AudioClip frase2fase5;
    public AudioClip frase3fase5;
     public AudioClip frase4fase5; 
     public AudioClip frase5fase5;
     public AudioClip frase6fase5;
    private Rigidbody2D rb2d;
	private Animator anim;
    public bool auxCheckValue;
    public bool isPaused;

	private bool facingRight = true;
	// Use this for initialization
	void Start () {

        TextPet.text = pet.ToString();
        TextVidro.text = vidro.ToString();
        TextMetal.text = metal.ToString();
        TextPapel.text = papel.ToString();
        TextVida.text = vida.ToString();
        TextOrganico.text = organico.ToString();
        TextPontuacao.text = pontuacao.ToString();

        rb2d = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}
    void Update()
    {

        // tempo
        if( tempo > 0) {
            tempo -= Time.deltaTime;
        }
        else if(tempo < 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        }
        txt.text = tempo.ToString("0");  

        // movimentar personagem direita e esquerda 

        if(vivo){

             float movimento = Input.GetAxis("Horizontal");
             transform.Translate(new Vector3(movimento * speed * Time.deltaTime, 0, 0));

            if (movimento < 0)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            else if (movimento > 0)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }

            //animacao movimentar
            if ((movimento > 0 || movimento < 0) && VerificaContatoChao)
            {
                GetComponent<Animator>().SetBool("run", true);
            }
            else
            {

                GetComponent<Animator>().SetBool("run", false);
            }

            //Pular
            if (Input.GetKeyDown(KeyCode.Space) && VerificaContatoChao)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 500));
            
                Gerenciador.inst.PlayAudio(jumpSound);
            }

            //animacao pular
            if (Input.GetKeyDown(KeyCode.Space) && VerificaContatoChao)
            {
                GetComponent<Animator>().SetBool("jump", true);
            
            }
            else
            {
                GetComponent<Animator>().SetBool("jump", false);

            }
         }   
	}

       
    private void OnTriggerEnter2D(Collider2D collision2d)
    {
        //verificar fase

        if (collision2d.gameObject.CompareTag("tutorial1"))
        {
            tutorial = true;
        }
          if (collision2d.gameObject.CompareTag("gmf1"))
        {
            VerificaContatofase1 = true;
        }
        if (collision2d.gameObject.CompareTag("gmf2"))
        {
            VerificaContatofase2 = true;
        }
        if (collision2d.gameObject.CompareTag("gmf3"))
        {
            VerificaContatofase3 = true;
        }

        if (collision2d.gameObject.CompareTag("gmf4"))
        {
            VerificaContatofase4 = true;
        }
        if (collision2d.gameObject.CompareTag("gmf5"))
        {
            VerificaContatofase5 = true;
        }
        
        //pegar lixo
        if (collision2d.gameObject.CompareTag("organico"))
        {
            Gerenciador.inst.PlayAudio(coletSound);
            Destroy(collision2d.gameObject);
            organico++;
            TextOrganico.text = organico.ToString();
            pontuacao+= 5;
            TextPontuacao.text = pontuacao.ToString();
        }
        if (collision2d.gameObject.CompareTag("pet"))
        {
            Gerenciador.inst.PlayAudio(coletSound);
            Destroy(collision2d.gameObject);
            pet++;
            TextPet.text = pet.ToString();
            pontuacao += 40;
            TextPontuacao.text = pontuacao.ToString();
        }

        if (collision2d.gameObject.CompareTag("vidro"))
        {
            Gerenciador.inst.PlayAudio(coletSound);
            Destroy(collision2d.gameObject);
            vidro++;
            TextVidro.text = vidro.ToString();
            pontuacao += 80;
            TextPontuacao.text = pontuacao.ToString();
        }
        if (collision2d.gameObject.CompareTag("papel"))
        {
            Gerenciador.inst.PlayAudio(coletSound);
            Destroy(collision2d.gameObject);
            papel++;
            TextPapel.text = papel.ToString();
            pontuacao += 10;
            TextPontuacao.text = pontuacao.ToString();
        }
        if (collision2d.gameObject.CompareTag("metal"))
        {
            Gerenciador.inst.PlayAudio(coletSound);
            Destroy(collision2d.gameObject);
            metal++;
            TextMetal.text = metal.ToString();
            pontuacao += 20;
            TextPontuacao.text = pontuacao.ToString();
        }
          if (collision2d.gameObject.CompareTag("tocha"))
        {
            Destroy(collision2d.gameObject);
        }
          if (collision2d.gameObject.CompareTag("r3"))
        {
            Gerenciador.inst.PlayAudio(coletSound);
            Destroy(collision2d.gameObject);
            r3++;
            TextR3.text = r3.ToString();
              
        }
          if (collision2d.gameObject.CompareTag("checkpoit"))
        {
            Gerenciador.inst.PlayAudio(coletSound);
            Destroy(collision2d.gameObject);
            tempo= 300.0f;
              
        }

        // jogar lixo na lixeira
        if (collision2d.gameObject.CompareTag("lixeira") && metal > 0 && organico>0 && papel > 0 && pet> 0 && vidro > 0 )
        { 
            lixeira = true;
            if(lixeira)
            {
                painelDoLixo.SetActive(true);
                speed=0;
            }
         }
           if (collision2d.gameObject.CompareTag("lixeira") &&VerificaContatofase5 )
        { 
            lixeira = true;
            if(lixeira)
            {
                painelDoLixo.SetActive(true);
                speed=0;
            }
         }
       
           if (collision2d.gameObject.CompareTag("lixeira2") &&VerificaContatofase5 )
        { 
            lixeira2 = true;
            if(lixeira2)
            {
                painelDoLixo4.SetActive(true);
             speed=0;
            }
         }
           if (collision2d.gameObject.CompareTag("lixeira3") &&VerificaContatofase5 )
        { 
            lixeira3 = true;
            if(lixeira3)
            {
                painelDoLixo3.SetActive(true);
            
            }
         }
           if (collision2d.gameObject.CompareTag("lixeira4") &&VerificaContatofase5 )
        { 
            lixeira4 = true;
            if(lixeira4)
            {
                painelDoLixo4.SetActive(true);
            speed=0;
            }
         }
           if (collision2d.gameObject.CompareTag("lixeira5") &&VerificaContatofase5 )
        { 
            lixeira5 = true;
            if(lixeira5)
            {
                painelDoLixo5.SetActive(true);
            
            }
         }
           if (collision2d.gameObject.CompareTag("bili")  )
        { 
                painelDoLixo6.SetActive(true);
          
         }
            if (collision2d.gameObject.CompareTag("close6")  )
        { 
                painelDoLixo6.SetActive(false);
          
         }
               if (collision2d.gameObject.CompareTag("c1")  )
        { 
                c1.SetActive(true);
                a+=1;
                if(a==1){
                    controle+=1;
                }
                
          
         }
                if (collision2d.gameObject.CompareTag("c2")  )
        { 
                c2.SetActive(true);
                  
                  b+=1;
                if(b==1){
                    controle+=1;
                }
                
         }
                  if (collision2d.gameObject.CompareTag("c3")  )
        { 
                c3.SetActive(true);
                  c+=1;
                if(c==1){
                    controle+=1;
                }
         }
                  if (collision2d.gameObject.CompareTag("c4")  )
        { 
                c4.SetActive(true);
                   d+=1;
                if(d==1){
                    controle+=1;
                }
         }
                  if (collision2d.gameObject.CompareTag("c5")  )
        { 
                c5.SetActive(true);
                   e+=1;
                if(e==1){
                    controle+=1;
                }
         }
                  if (collision2d.gameObject.CompareTag("c6")  )
        { 
                c6.SetActive(true);
                  f+=1;
                if(f==1){
                    controle+=1;
                }
         }
                  if (collision2d.gameObject.CompareTag("c7")  )
        { 
                c7.SetActive(true);
                   g+=1;
                if(g==1){
                    controle+=1;
                }
          
         }
               if (collision2d.gameObject.CompareTag("moeda")  )
        { 
                c8.SetActive(true);
                   h+=1;
                if(h==1){
                    controle+=1;
                }
          
         }

         if (collision2d.gameObject.CompareTag("rreduzir")  )
        { 
                rreduzir.SetActive(true);
                Destroy(collision2d.gameObject);
                painel+=1;
                Gerenciador.inst.PlayAudio(coletSound);
          
         }
           if (collision2d.gameObject.CompareTag("ereduzir")  )
        { 
                ereduzir.SetActive(true);
                Destroy(collision2d.gameObject);
                 painel+=1;
                 Gerenciador.inst.PlayAudio(coletSound);
         }
           if (collision2d.gameObject.CompareTag("dreduzir")  )
        { 
                dreduzir.SetActive(true);
                Destroy(collision2d.gameObject);
                 painel+=1;
                 Gerenciador.inst.PlayAudio(coletSound);
         }
           if (collision2d.gameObject.CompareTag("ureduzir")  )
        { 
                ureduzir.SetActive(true);
            Destroy(collision2d.gameObject);
             painel+=1;
             Gerenciador.inst.PlayAudio(coletSound);
         }
           if (collision2d.gameObject.CompareTag("zreduzir")  )
        { 
                zreduzir.SetActive(true);
          Destroy(collision2d.gameObject);
           painel+=1;
           Gerenciador.inst.PlayAudio(coletSound);
         }
           if (collision2d.gameObject.CompareTag("ireduzir")  )
        { 
                ireduzir.SetActive(true);
          Destroy(collision2d.gameObject);
           painel+=1;
           Gerenciador.inst.PlayAudio(coletSound);
         }
           if (collision2d.gameObject.CompareTag("r2reduzir")  )
        { 
                r2reduzir.SetActive(true);
          Destroy(collision2d.gameObject);
           painel+=1;
           Gerenciador.inst.PlayAudio(coletSound);
         }


           if (collision2d.gameObject.CompareTag("rreciclar")  )
        { 
                rreciclar.SetActive(true);
          Destroy(collision2d.gameObject);
           painel+=1;
           Gerenciador.inst.PlayAudio(coletSound);
         }
             if (collision2d.gameObject.CompareTag("rreciclar")  )
        { 
                rreciclar.SetActive(true);
          Destroy(collision2d.gameObject);
           painel+=1;
           Gerenciador.inst.PlayAudio(coletSound);
         }
             if (collision2d.gameObject.CompareTag("rreciclar")  )
        { 
                rreciclar.SetActive(true);
          Destroy(collision2d.gameObject);
           painel+=1;
           Gerenciador.inst.PlayAudio(coletSound);
         }
             if (collision2d.gameObject.CompareTag("ereciclar")  )
        { 
                ereciclar.SetActive(true);
          Destroy(collision2d.gameObject);
           painel+=1;
           Gerenciador.inst.PlayAudio(coletSound);
         }
             if (collision2d.gameObject.CompareTag("creciclar")  )
        { 
                creciclar.SetActive(true);
          Destroy(collision2d.gameObject);
           painel+=1;
           Gerenciador.inst.PlayAudio(coletSound);
         }
             if (collision2d.gameObject.CompareTag("ireciclar")  )
        { 
                ireciclar.SetActive(true);
          Destroy(collision2d.gameObject);
           painel+=1;
           Gerenciador.inst.PlayAudio(coletSound);
         }
             if (collision2d.gameObject.CompareTag("c2reciclar")  )
        { 
                c2reciclar.SetActive(true);
          Destroy(collision2d.gameObject);
           painel+=1;
           Gerenciador.inst.PlayAudio(coletSound);
         }
             if (collision2d.gameObject.CompareTag("lreciclar")  )
        { 
                lreciclar.SetActive(true);
          Destroy(collision2d.gameObject);
           painel+=1;
           Gerenciador.inst.PlayAudio(coletSound);
         }
               if (collision2d.gameObject.CompareTag("areciclar")  )
        { 
                areciclar.SetActive(true);
          Destroy(collision2d.gameObject);
           painel+=1;
           Gerenciador.inst.PlayAudio(coletSound);
         }
                if (collision2d.gameObject.CompareTag("r2reciclar")  )
        { 
                r2reciclar.SetActive(true);
          Destroy(collision2d.gameObject);
           painel+=1;
           Gerenciador.inst.PlayAudio(coletSound);
         }

                if (collision2d.gameObject.CompareTag("rreutilizar")  )
        { 
                rreutilizar.SetActive(true);
          Destroy(collision2d.gameObject);
           painel+=1;
           Gerenciador.inst.PlayAudio(coletSound);
         }

               if (collision2d.gameObject.CompareTag("ereutilizar")  )
        { 
                ereutilizar.SetActive(true);
          Destroy(collision2d.gameObject);
           painel+=1;
           Gerenciador.inst.PlayAudio(coletSound);
         }
               if (collision2d.gameObject.CompareTag("ureutilizar")  )
        { 
                ureutilizar.SetActive(true);
          Destroy(collision2d.gameObject);
           painel+=1;
           Gerenciador.inst.PlayAudio(coletSound);
         }

       if (collision2d.gameObject.CompareTag("treutilizar")  )
        { 
                treutilizar.SetActive(true);
          Destroy(collision2d.gameObject);
           painel+=1;
           Gerenciador.inst.PlayAudio(coletSound);
         }

       if (collision2d.gameObject.CompareTag("ireutilizar")  )
        { 
                ireutilizar.SetActive(true);
          Destroy(collision2d.gameObject);
           painel+=1;
           Gerenciador.inst.PlayAudio(coletSound);
         }

       if (collision2d.gameObject.CompareTag("lreutilizar")  )
        { 
                lreutilizar.SetActive(true);
          Destroy(collision2d.gameObject);
           painel+=1;
           Gerenciador.inst.PlayAudio(coletSound);
         }

       if (collision2d.gameObject.CompareTag("i2reutilizar")  )
        { 
                i2reutilizar.SetActive(true);
          Destroy(collision2d.gameObject);
           painel+=1;
           Gerenciador.inst.PlayAudio(coletSound);
         }

       if (collision2d.gameObject.CompareTag("zreutilizar")  )
        { 
                zreutilizar.SetActive(true);
          Destroy(collision2d.gameObject);
           painel+=1;
           Gerenciador.inst.PlayAudio(coletSound);
         }

       if (collision2d.gameObject.CompareTag("areutilizar")  )
        { 
                areutilizar.SetActive(true);
          Destroy(collision2d.gameObject);
           painel+=1;
           Gerenciador.inst.PlayAudio(coletSound);
         }
         if (collision2d.gameObject.CompareTag("r2reutilizar")  )
        { 
                r2reutilizar.SetActive(true);
          Destroy(collision2d.gameObject);
           painel+=1;
           Gerenciador.inst.PlayAudio(coletSound);
         }


        if (collision2d.gameObject.CompareTag("checkpoint"))
        {
            lastCheckpoint = collision2d.gameObject;
        }
        if (collision2d.gameObject.CompareTag("final"))
        {
            if(pontuacao>=1550){
                UnityEngine.SceneManagement.SceneManager.LoadScene("QuizFase1");
			}
            else if(fraseSound9){
                 GetComponent<AudioSource> ().PlayOneShot (frase9);
                 fraseSound9 = false;     
			}
        }
         if (collision2d.gameObject.CompareTag("final3"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("QuizFase3");
        }
        if (collision2d.gameObject.CompareTag("final4"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("QuizFase4");
        }
          if (collision2d.gameObject.CompareTag("final5") && controle==8 && painel>=25)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("parabens");
        }
          
        //audios fase1
        if (collision2d.gameObject.CompareTag("frase")){
            if(fraseSound){
                 GetComponent<AudioSource> ().PlayOneShot (frase);
                 fraseSound = false;
			}
        }
        if (collision2d.gameObject.CompareTag("frase2")){
            if(fraseSound2){
                 GetComponent<AudioSource> ().PlayOneShot (frase2);
                 fraseSound2 = false;
			}
        }
        if (collision2d.gameObject.CompareTag("frase3")){
            if(fraseSound3){
                 GetComponent<AudioSource> ().PlayOneShot (frase3);
                 fraseSound3 = false;
			}
        }
        if (collision2d.gameObject.CompareTag("frase4")){
            if(fraseSound4){
                 GetComponent<AudioSource> ().PlayOneShot (frase4);
                 fraseSound4 = false;
			}
        }
        if (collision2d.gameObject.CompareTag("frase5")){
            if(fraseSound5){
                 GetComponent<AudioSource> ().PlayOneShot (frase5);
                 fraseSound5 = false;
			}
        }
        if (collision2d.gameObject.CompareTag("frase6")){
            if(fraseSound){
                 GetComponent<AudioSource> ().PlayOneShot (frase6);
                 fraseSound6 = false;
			}
        }
        if (collision2d.gameObject.CompareTag("frase7")){
            if(fraseSound7){
                 GetComponent<AudioSource> ().PlayOneShot (frase7);
                 fraseSound7 = false;
			}
        }
        if (collision2d.gameObject.CompareTag("frase8")){
            if(fraseSound8){
                 GetComponent<AudioSource> ().PlayOneShot (frase8);
                 fraseSound8 = false;
			}
        }
           if (collision2d.gameObject.CompareTag("seila")){
            if(seilaSound){
                 GetComponent<AudioSource> ().PlayOneShot (seila);
                 seilaSound = false;
			}
        }
           if (collision2d.gameObject.CompareTag("seila2")){
            if(seila2Sound){
                 GetComponent<AudioSource> ().PlayOneShot (seila2);
                 seila2Sound = false;
			}
        }

        //audios fase2 

         if (collision2d.gameObject.CompareTag("fraseFase21")){
            if(fraseFase2Sound){
                 GetComponent<AudioSource> ().PlayOneShot (fraseFase21);
                 fraseFase2Sound = false;
			}
        }
        if (collision2d.gameObject.CompareTag("fraseFase22")){
            if(fraseFase2Sound2){
                 GetComponent<AudioSource> ().PlayOneShot (fraseFase22);
                 fraseFase2Sound2 = false;
			}
        }
        if (collision2d.gameObject.CompareTag("fraseFase23")){
            if(fraseFase2Sound3){
                 GetComponent<AudioSource> ().PlayOneShot (fraseFase23);
                 fraseFase2Sound3 = false;
			}
        }
        if (collision2d.gameObject.CompareTag("fraseFase24")){
            if(fraseFase2Sound4){
                 GetComponent<AudioSource> ().PlayOneShot (fraseFase24);
                 fraseFase2Sound4 = false;
			}
        }
        if (collision2d.gameObject.CompareTag("fraseFase25")){
            if(fraseFase2Sound5){
                 GetComponent<AudioSource> ().PlayOneShot (fraseFase25);
                 fraseFase2Sound5 = false;
			}
        }
        if (collision2d.gameObject.CompareTag("fraseFase26")){
            if(fraseFase2Sound6){
                 GetComponent<AudioSource> ().PlayOneShot (fraseFase26);
                 fraseFase2Sound6 = false;
			}
        }
     
         //audios fase3
        if (collision2d.gameObject.CompareTag("frase1fase3")){
            if(fase3FraseSound){
                    GetComponent<AudioSource> ().PlayOneShot (frase1fase3);
                    fase3FraseSound = false;
            }
        }
         if (collision2d.gameObject.CompareTag("frase2fase3")){
            if(fase3FraseSound2){
                    GetComponent<AudioSource> ().PlayOneShot (frase2fase3);
                    fase3FraseSound2 = false;
            }
        }
         if (collision2d.gameObject.CompareTag("frase3fase3")){
            if(fase3FraseSound3){
                    GetComponent<AudioSource> ().PlayOneShot (frase3fase3);
                    fase3FraseSound3 = false;
            }
        }
         if (collision2d.gameObject.CompareTag("frase4fase3")){
            if(fase3FraseSound4){
                    GetComponent<AudioSource> ().PlayOneShot (frase4fase3);
                    fase3FraseSound4 = false;
            }
        }
         if (collision2d.gameObject.CompareTag("frase5fase3")){
            if(fase3FraseSound5){
                    GetComponent<AudioSource> ().PlayOneShot (frase5fase3);
                    fase3FraseSound5 = false;
            }
        }



        //audios fase4
        if (collision2d.gameObject.CompareTag("Fase4Frase1")){
            if(fase4FraseSound){
                 GetComponent<AudioSource> ().PlayOneShot (Fase4Frase1);
                 fase4FraseSound = false;
			}
        }
        if (collision2d.gameObject.CompareTag("Fase4Frase2")){
            if(fase4FraseSound2){
                 GetComponent<AudioSource> ().PlayOneShot (Fase4Frase2);
                 fase4FraseSound2 = false;
			}
        }
        if (collision2d.gameObject.CompareTag("Fase4Frase3")){
            if(fase4FraseSound3){
                 GetComponent<AudioSource> ().PlayOneShot (Fase4Frase3);
                 fase4FraseSound3 = false;
			}
        }
        if (collision2d.gameObject.CompareTag("Fase4Frase4")){
            if(fase4FraseSound4){
                 GetComponent<AudioSource> ().PlayOneShot (Fase4Frase4);
                 fase4FraseSound4 = false;
			}
        }

        //audiosfase5

      if (collision2d.gameObject.CompareTag("1")){
            if(fase5FraseSound){
                 GetComponent<AudioSource> ().PlayOneShot (frase1fase5);
                 fase5FraseSound = false;
			}
        }
          if (collision2d.gameObject.CompareTag("2")){
            if(fase5FraseSound2){
                 GetComponent<AudioSource> ().PlayOneShot (frase2fase5);
                 fase5FraseSound2 = false;
			}
        }
          if (collision2d.gameObject.CompareTag("3")){
            if(fase3FraseSound3){
                 GetComponent<AudioSource> ().PlayOneShot (frase3fase5);
                 fase3FraseSound3 = false;
			}
        }
          if (collision2d.gameObject.CompareTag("4")){
            if(fase5FraseSound4){
                 GetComponent<AudioSource> ().PlayOneShot (frase4fase5);
                 fase5FraseSound4 = false;
			}
        }
          if (collision2d.gameObject.CompareTag("5")){
            if(fase5FraseSound5){
                 GetComponent<AudioSource> ().PlayOneShot (frase5fase5);
                 fase5FraseSound5 = false;
			}
        }
          if (collision2d.gameObject.CompareTag("6")){
            if(fase5FraseSound6){
                 GetComponent<AudioSource> ().PlayOneShot (frase6fase5);
                 fase5FraseSound6 = false;
			}
        }


        //pontuacao inimigos
        if (collision2d.gameObject.CompareTag("escorpiao"))
        {
            pontuacao+= 100;
            TextPontuacao.text = pontuacao.ToString();
        }
        if (collision2d.gameObject.CompareTag("rato"))
        {
            pontuacao+= 50;
            TextPontuacao.text = pontuacao.ToString();
        }    
        if (collision2d.gameObject.CompareTag("mosca"))
        {
            pontuacao+= 40;
            TextPontuacao.text = pontuacao.ToString();
        }   
        if (collision2d.gameObject.CompareTag("barata"))
        {
            pontuacao+= 30;
            TextPontuacao.text = pontuacao.ToString();
        }
        if (collision2d.gameObject.CompareTag("escorpiao") || collision2d.gameObject.CompareTag("rato")
        || collision2d.gameObject.CompareTag("mosca") || collision2d.gameObject.CompareTag("barata") || collision2d.gameObject.CompareTag("agua")
        || collision2d.gameObject.CompareTag("aranha"))
        {
            Gerenciador.inst.PlayAudio(deathS);
        }
    }
    void OnCollisionEnter2D(Collision2D collision2d)
    {
        if (collision2d.gameObject.CompareTag("chao"))
        {
            VerificaContatoChao = true;
        }

        //morrer
        if (collision2d.gameObject.CompareTag("escorpiao") || collision2d.gameObject.CompareTag("rato")
        || collision2d.gameObject.CompareTag("mosca") || collision2d.gameObject.CompareTag("barata") || collision2d.gameObject.CompareTag("agua")
        || collision2d.gameObject.CompareTag("aranha"))
        {
            vivo=false;
            collision2d.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(500,0));
            Gerenciador.inst.PlayAudio(deathSound);
            vida--;
            TextVida.text = vida.ToString();

         

            if (vida == 0)
            {
                if(VerificaContatofase1){
                     StartCoroutine("GameOver");
				}
                else if(VerificaContatofase2){
                    StartCoroutine("GameOverFase2");
				}
                else if(VerificaContatofase3){
                    StartCoroutine("GameOverFase3");
				}
                else if(VerificaContatofase4){
                    StartCoroutine("GameOverFase4");
				}
                else if(VerificaContatofase5){
                    StartCoroutine("GameOverFase5");
				}
            }
            else if(vida <5 && vida>=0)
            {
                if(VerificaContatofase1){
                     StartCoroutine("Inicio");
				}
                else if(VerificaContatofase2){
                    StartCoroutine("InicioFase2");
				}   
                 else if(VerificaContatofase3){
                    StartCoroutine("InicioFase3");
				}  
                else if(VerificaContatofase4){
                    StartCoroutine("InicioFase4");
				}   
                 else if(VerificaContatofase5){
                    StartCoroutine("InicioFase5");
				} 
            }
        }
   
    }
    IEnumerator GameOver()
    {
        vivo=false;
        yield return new WaitForSeconds(0);
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
    }
     IEnumerator GameOverFase2()
    {
        vivo=false;
        yield return new WaitForSeconds(0);
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOverFase2");
    }
     IEnumerator GameOverFase3()
    {
        vivo=false;
        yield return new WaitForSeconds(0);
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOverFase3");
    }
     IEnumerator GameOverFase4()
    {
        vivo=false;
        yield return new WaitForSeconds(0);
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOverFase4");
    }
       IEnumerator GameOverFase5()
    {
        vivo=false;
        yield return new WaitForSeconds(0);
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOverFase5");
    }
    IEnumerator Inicio()
    {
        yield return new WaitForSeconds(0);
        transform.position = lastCheckpoint.transform.position;
       
        fraseSound= true;
        fraseSound2= true;
        fraseSound3= true;
        fraseSound4= true;
        fraseSound5= true;
        fraseSound6= true;
        fraseSound7= true;
        fraseSound8= true;
        tempo= 300.0f;
        vivo=true;  
    }
     IEnumerator InicioFase2()
    {
        yield return new WaitForSeconds(0);
        transform.position = lastCheckpoint.transform.position;
        fraseFase2Sound= true;
        fraseFase2Sound2= true;
        fraseFase2Sound3= true;
        fraseFase2Sound4= true;
        fraseFase2Sound5= true;
        fraseFase2Sound6= true;
        fraseFase2Sound7= true;
        fraseFase2Sound8= true;
        tempo= 300.0f;
        vivo=true;
    }
       IEnumerator InicioFase3()
    {
     
        yield return new WaitForSeconds(0);
        transform.position = lastCheckpoint.transform.position;
        fase3FraseSound= true;
        fase3FraseSound2= true;
        fase3FraseSound3= true;
        fase3FraseSound4= true;
        fase3FraseSound5= true;
        tempo= 300.0f;
        vivo=true;
    }
        IEnumerator InicioFase4()
    {
        yield return new WaitForSeconds(0);
        transform.position = lastCheckpoint.transform.position;
        fase4FraseSound = true;
        fase4FraseSound2 = true;
        fase4FraseSound3 = true;
        fase4FraseSound4 = true;
        tempo= 300.0f;
        vivo=true; 
       
    }
        IEnumerator InicioFase5()
    {
        yield return new WaitForSeconds(0);
        transform.position = lastCheckpoint.transform.position;
        tempo= 300.0f;
        vivo=true; 
       
    }

    void OnCollisionExit2D(Collision2D collision2d)
    {
        if (collision2d.gameObject.CompareTag("chao"))
        {
            VerificaContatoChao = false;
        }
    }

    void Flip()
	{
		facingRight = !facingRight;

		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}


