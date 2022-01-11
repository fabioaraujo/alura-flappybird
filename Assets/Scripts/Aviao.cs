using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    private Rigidbody2D fisica;
    [SerializeField]
    private float forca = 5;

    //metodo que o Unity usa ao inicializar a classe
    private void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();
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
        this.fisica.AddForce(Vector2.up * this.forca, ForceMode2D.Impulse);
    }
}
