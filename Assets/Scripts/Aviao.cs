using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    private Rigidbody2D fisica;
    [SerializeField]
    private float forca = 5;

    private Diretor diretor;

    //metodo que o Unity usa ao inicializar a classe
    private void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();

        this.diretor = GameObject.FindObjectOfType<Diretor>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            this.Impulsionar();
        }
                
    }

    private void Impulsionar()
    {
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * this.forca, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //se bater em algo parar de simular fisica
        this.fisica.simulated = false;

        this.diretor.FinalizarJogo();
    }
}
