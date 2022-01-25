using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    public void FinalizarJogo()
    {
        //para o tempo de todo o jogo, paraliza tudo no jogo
        Time.timeScale = 0;
    }
}
