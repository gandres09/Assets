using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiarEscenaAJugar : MonoBehaviour
{
    public void menuJuego()
    {
            SceneManager.LoadScene("JuegoEscena");
    }
}