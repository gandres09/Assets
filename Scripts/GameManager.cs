using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int contador;
    public Text textoContador;

    // Start is called before the first frame update
    void Start()
    {
        //Inicializo el contador
        textoContador.text = "0";
    }

    // Update is called once per frame

            //Actualizo el contador (desde DestruirPorContacto)
    public void actualizarContador(){
        contador += 1;
        textoContador.text = contador.ToString();
    }
}

