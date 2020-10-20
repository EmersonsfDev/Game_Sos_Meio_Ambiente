using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class MusicControl : MonoBehaviour
{

    public GameObject musica1;

    public GameObject musica2;

    // Use this for initialization

    void Start()
    {

        Instantiate(musica1, new Vector2(0, 0), Quaternion.identity);

    }

    // Update is called once per frame

    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D outro)
    {

        if (outro.gameObject.CompareTag("separaçao"))
        {

            Destroy(musica1);

            Instantiate(musica2, new Vector2(0, 0), Quaternion.identity);
        }

    }



}
