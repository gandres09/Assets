using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruirBala : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

       }

    // Update is called once per frame
    void Update()
    { //Aqui se destruye la bala cuando se sale de la pantalla
        if (gameObject.transform.position.x < -2f) {
            Destroy(gameObject);
        }
        if (gameObject.transform.position.x > 2f) {
            Destroy(gameObject);
        }
        if (gameObject.transform.position.y > 1.2f) {
            Destroy(gameObject);
        }
        if (gameObject.transform.position.y < -1.2f) {
            Destroy(gameObject);
        } 
    }
}
