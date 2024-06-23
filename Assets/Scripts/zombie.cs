using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zombie : MonoBehaviour
{
    public float velocidad = 2f; // Velocidad de movimiento
    public float amplitud = 2.5f; // Amplitud del movimiento lateral
    private Vector3 posicionInicial;
    
    void Start()
    {
        posicionInicial = transform.position;
    }

    void Update()
    {
        // Calcula el desplazamiento lateral usando una función seno
        float desplazamientoLateral = Mathf.Sin(Time.time * velocidad) * amplitud;

        // Calcula la nueva posición
        Vector3 nuevaPosicion = posicionInicial + Vector3.right * desplazamientoLateral;

        // Aplica la nueva posición
        transform.position = nuevaPosicion;
    }
    
}
