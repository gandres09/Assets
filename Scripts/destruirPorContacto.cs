using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class destruirPorContacto : MonoBehaviour
{

    private GameManager gameManager;
    void Start()
    {
        //Busco el script de GameManager
        gameManager = FindObjectOfType<GameManager>();
    }

    //Al entrar en el objeto
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag != "Limites" || other.gameObject.tag != "Meteorito") {
        if(other.gameObject.tag == "Player") {
            SceneManager.LoadScene("Menu");
        }
        if(other.gameObject.tag == "bala"){
            Destroy(other.gameObject);
            Destroy(gameObject);
            
            //Actualizo el contador
            gameManager.actualizarContador();
        }
        }
    }
}