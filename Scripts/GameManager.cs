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

    public int contadorHighScore = 0;

    public Text textoHighScore;

    // Start is called before the first frame update
    void Start()
    {
        //Inicializo el contador
        textoContador.text = "0";
        textoHighScore.text = "High Score: " + contadorHighScore;

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

    //se guarda el contador en un archivo para un highscore
    public void guardarContador()
    {
        string path = Application.persistentDataPath + "/contador.txt";
        System.IO.File.WriteAllText(path, contador.ToString());
    }

    //se carga el contador del archivo para un highscore
    public void cargarContador()
    {
        string path = Application.persistentDataPath + "/contador.txt";
        if (System.IO.File.Exists(path))
        {
            string contadorString = System.IO.File.ReadAllText(path);
            contadorHighScore = int.Parse(contadorString);
        }
    }

    // usa highscore para ver si el contador es mayor que el highscore
    public void verificarHighScore()
    {
        string path = Application.persistentDataPath + "/contador.txt";
        if (System.IO.File.Exists(path))
        {
            string contadorString = System.IO.File.ReadAllText(path);
            contadorHighScore = int.Parse(contadorString);
            if (contador > contadorHighScore)
            {
                guardarContador();
            }
        }
    }

    //poner el contadorHighScore en texto
    public void ponerContadorHighScore()
    {
        textoHighScore.text = contadorHighScore.ToString();
    }

}

