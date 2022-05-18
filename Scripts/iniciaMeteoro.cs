using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iniciaMeteoro : MonoBehaviour
{
    public Rigidbody2D meteoritoRigidBody;
    public float velocidadAparicion = 1f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ApareceMeteoro", velocidadAparicion, velocidadAparicion);
    }

    void ApareceMeteoro()
    {

        float numeroRandomX1 = Random.Range(-2f, -1.65f);
        float numeroRandomX2 = Random.Range(1.65f, 2f);
        float numeroRandomY1 = Random.Range(-1f, -0.86f);
        float numeroRandomY2 = Random.Range(0.86f, 1f);
        int numeroRandom = Random.Range(0, 3);
        if (numeroRandom == 0)
        {
            //poner prefab meteorito en la posicion de la variable numeroRandomX1 y numeroRandomY1
            Rigidbody2D meteoritoClone = Instantiate(meteoritoRigidBody, transform.position, transform.rotation);
            meteoritoClone.transform.position = new Vector3(numeroRandomX1, numeroRandomY1, 1);
        }
        else if (numeroRandom == 1)
        {
            //poner prefab meteorito en la posicion de la variable numeroRandomX2 y numeroRandomY1
            Rigidbody2D meteoritoClone = Instantiate(meteoritoRigidBody, transform.position, transform.rotation);
            meteoritoClone.transform.position = new Vector3(numeroRandomX2, numeroRandomY1, 1);
        }
        else if (numeroRandom == 2)
        {
            //poner prefab meteorito en la posicion de la variable numeroRandomX1 y numeroRandomY2
            Rigidbody2D meteoritoClone = Instantiate(meteoritoRigidBody, transform.position, transform.rotation);
            meteoritoClone.transform.position = new Vector3(numeroRandomX1, numeroRandomY2, 1);
        }
        else if (numeroRandom == 3)
        {
            //poner prefab meteorito en la posicion de la variable numeroRandomX2 y numeroRandomY2
            Rigidbody2D meteoritoClone = Instantiate(meteoritoRigidBody, transform.position, transform.rotation);
            meteoritoClone.transform.position = new Vector3(numeroRandomX2, numeroRandomY2, 1);
        }
    }

}
