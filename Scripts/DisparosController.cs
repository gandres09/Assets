using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparosController : MonoBehaviour
{

    //Declarlo la variable de tipo RigidBody que luego asociaremos a nuestro objeto
    private Rigidbody2D rb;
    private GameObject bala;

    public GameObject meteorito;

    //Declaro la variable pública velocidad para poder modificarla desde la Inspector window
    public float velocidad = 20;

    void Start()
    {

        //Capturo el rigidbody2D del jugador al iniciar el juego
        rb = GetComponent<Rigidbody2D>();

        //Aplico movimiento en dirección x positiva (con su velocidad)
        rb.velocity = transform.up * velocidad;

    }

}