using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarCounter : MonoBehaviour
{

    // Start is called before the first frame update
    public int value;
    public GameObject canvas; // Referencia al GameObject del canvas



    void Start()
    {

        EventoDesactivarCanvas();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Star"))
        {
            Destroy(other.gameObject);
            CountStarts.instance.IncreaseStar(value);
            if (CountStarts.starCount == 5)
            {
                EventoActivarCanvas();

            }

        }
        if (other.CompareTag("Dino"))
        {

            EventoActivarCanvas();

        }
    }


    public void EventoActivarCanvas()
    {
        canvas.SetActive(true); // Activa el canvas
        Time.timeScale = 0.0f; // Detiene el tiempo en la escena
    }


    void EventoDesactivarCanvas()
    {
        canvas.SetActive(false); // Desactiva el canvas
        Time.timeScale = 1.0f; // Reanuda el tiempo en la escena
    }
    
}
