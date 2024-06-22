using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour
{
    // Start is called before the first frame update
        public GameObject canvas; // Referencia al GameObject del canvas

    void EventoDesactivarCanvas()
    {
        canvas.SetActive(false); // Desactiva el canvas
        Time.timeScale = 1.0f; // Reanuda el tiempo en la escena
    }

    public void OnButtonReiniciar()
    {
        EventoDesactivarCanvas(); // Cierra el canvas y reanuda la escena
        reiniciarScene();
    }

    void reiniciarScene()
    {
        // Carga la escena actual de nuevo
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
