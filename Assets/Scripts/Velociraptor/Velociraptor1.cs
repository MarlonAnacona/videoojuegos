using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velociraptor1 : MonoBehaviour
{
    public float velocidad = 2f; // Velocidad de movimiento
    private int direccion = 1; // Variable para controlar la dirección del movimiento (1 para adelante, -1 para atrás)

    // Update is called once per frame
    void Update()
    {
        // Mueve el objeto en la dirección del eje Z (forward) a la velocidad especificada y multiplicado por la dirección
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad * direccion);

        // Limita la posición en el eje X entre -2.5 y 2.5
        Vector3 posicionActual = transform.position;
        posicionActual.x = Mathf.Clamp(posicionActual.x, -2.5f, 2.5f);
        transform.position = posicionActual;

        // Si el objeto alcanza los límites, cambia la dirección
        if (posicionActual.x >= 2.5f || posicionActual.x <= -2.5f)
        {
            direccion *= -1; // Cambia la dirección
        }
    }
}
