using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPorLimites : MonoBehaviour {

    //Al salir de la colisión
	private void OnTriggerExit2D(Collider2D other) {
        //Destruyo el objeto que ha salido de la colisión
        Destroy(other.gameObject);
    }
}