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

    public int contadorHighScore;

    public Text textoContadorHighScore;


    // Start is called before the first frame update
    void Start()
    {
        //Inicializo el contador
        textoContador.text = "0";
        contadorHighScore = PlayerPrefs.GetInt("HighScore");
        textoContadorHighScore.text = "Highscore: " + contadorHighScore.ToString();
    }

    //Actualizo el contador (desde DestruirPorContacto)
    public void actualizarContador()
    {
        contador += 1;
        textoContador.text = contador.ToString();

        if (contador > contadorHighScore)
        {
            contadorHighScore = contador;
            textoContadorHighScore.text = "Highscore: " + contadorHighScore.ToString();
            PlayerPrefs.SetInt("HighScore", contadorHighScore);
        }
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

