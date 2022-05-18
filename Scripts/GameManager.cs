using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Camera cam;
    public float duracion = 1.5f;
    public float magnitud = 1.5f;
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
    public void actualizarContador()
    {
        contador += 1;
        textoContador.text = contador.ToString();
    }

    public void trueWait()
    {
        StartCoroutine(Wait());
    }

    public IEnumerator Wait()
    {
        Vector3 inicioCamara = cam.transform.position;
        while (duracion > 0)
        {
            float x = Random.Range(-1f, 1f) * magnitud;
            float y = Random.Range(-1f, 1f) * magnitud;
            cam.transform.position = new Vector3(cam.transform.position.x + x, cam.transform.position.y + y, 0);

            yield return new WaitForSeconds(duracion);
            duracion--;
        }
        cam.transform.position = inicioCamara;
        SceneManager.LoadScene("Menu");

    }

}

