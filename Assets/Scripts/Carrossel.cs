using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrossel : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.1f;

    private Vector3 posicaoInicial;
    private float tamanhoImagem;

    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        this.tamanhoImagem = this.GetComponent<SpriteRenderer>().size.x * this.transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, this.tamanhoImagem);

        this.transform.position = this.posicaoInicial + (Vector3.left * deslocamento);
    }
}
