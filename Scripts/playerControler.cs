using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour

{
    public AudioSource sonidoDisparo;
    //Declarlo la variable de tipo RigidBody que luego asociaremos a nuestro objeto
    private Rigidbody2D rb;

    //Declaro la variable pública velocidad para poder modificarla desde la Inspector window
    [Range(5, 15)]
    public float velocidad = 10;

    //Declaro la variable de tipo GameObject que luego asociaremos a nuestro prefab Disparos
    public GameObject disparo;

    //Declaro la variable de tipo Transform para la posición del disparador
    public Transform disparador;

    //Declaro la variable de tipo float velocidadDisparo para la velocidad con la que puedo generar disparos
    [Range(0, 1)]
    public float velocidadDisparo = 0.25f; //4 por segundo

    //Tiempo que tiene que transcurrir hasta el próximo disparo
    private float proximoDisparo;



    // Start is called before the first frame update

    void Start()
    {

        //Capturo el rigidbody del jugador al iniciar el juego
        rb = GetComponent<Rigidbody2D>();

    }

    // Actualiza el llamado cada frame
    void Update()
    {
        if ((Input.GetKey("a") || Input.GetKey("left")) && gameObject.transform.position.x > -1.65f)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + -2f * Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if ((Input.GetKey("d") || Input.GetKey("right")) && gameObject.transform.position.x < 1.65f)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 2f * Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if ((Input.GetKey("w") || Input.GetKey("up")) && gameObject.transform.position.y < 0.86f)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 2f * Time.deltaTime, gameObject.transform.position.z);
        }
        if ((Input.GetKey("s") || Input.GetKey("down")) && gameObject.transform.position.y > -0.86f)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + -2f * Time.deltaTime, gameObject.transform.position.z);
        }
        if (Input.GetButton("Fire1") && Time.time > proximoDisparo)
        {
            //Incremento el valor de proximo disparo
            proximoDisparo = Time.time + velocidadDisparo;

            //Instancio un nuevo disparo en esa posición y con esa rotación
            Instantiate(disparo, disparador.position, disparador.rotation);

            //Reproduzco el sonido del disparo
            sonidoDisparo.Play();

        }
    }

}
