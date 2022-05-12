using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoBotones : MonoBehaviour
{
    public collider2D botonJugar;
    public bool botonJugarEntra;



    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        //si la mouse esta encima del boton
        if (botonJugar.isMouseEnter)
        {
            //cambio booleano a true
            botonJugarEntra = true;
        }

        if (botonJugar.isMouseExit)
        {
            //cambio booleano a false
            botonJugarEntra = false;
        }
        else
        {
            botonJugarEntra = false;
        }

    }

}

