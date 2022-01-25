using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    private Rigidbody2D fisica;
    [SerializeField]
    private float forca = 5;

    private Vector3 posicaoInicial;

    private Diretor diretor;

    //metodo que o Unity usa ao inicializar a classe
    private void Awake()//aqui alguns objetos da cena podem não existir ainda
    {
        this.fisica = this.GetComponent<Rigidbody2D>();

        this.posicaoInicial = this.transform.position;
    }

    private void Start() //a cena já foi criada com todos os objetos
    {
        this.diretor = GameObject.FindObjectOfType<Diretor>();
    }

    // Update is called once per frame
    private void Update()
    {
        this.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
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

    public void Reiniciar()
    {
        this.transform.position = this.posicaoInicial;
        
        this.fisica.simulated = true;
    }
}
