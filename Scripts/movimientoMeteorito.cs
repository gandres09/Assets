using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoMeteorito : MonoBehaviour
{
    public int velocidad = 10;

    public Rigidbody2D meteoritoRigidBody;

    // un private de coordenadas llamado moveMeteorito
    private Vector3 moveMeteorito;

    private Vector3 lookAtDirection;

    // Start is called before the first frame update
    void Start()
    {
        //numero random para que el meteorito se mueva en una dirección aleatoria
        float numeroRandomX = Random.Range(-1.65f, 1.65f);
        float numeroRandomY = Random.Range(-0.86f, 0.86f);
        moveMeteorito = new Vector3(numeroRandomX, numeroRandomY, 1);
        Vector3 lookAtDirection = moveMeteorito - transform.position;
        transform.up = lookAtDirection;
        lookAtDirection.z = 1;
        meteoritoRigidBody.AddForce(velocidad * (moveMeteorito - transform.position));
    }

    // Update is called once per frame
    void Update()
    {

    }
}