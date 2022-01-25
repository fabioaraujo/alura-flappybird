using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    [SerializeField]
    private GameObject imagemGameOver;
    public void FinalizarJogo()
    {
        //para o tempo de todo o jogo, paraliza tudo no jogo
        Time.timeScale = 0;

        //habilitar imagem de Game Over
        this.imagemGameOver.SetActive(true);
    }
}
