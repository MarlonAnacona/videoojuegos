using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerMoneda : MonoBehaviour
{
    public Puntaje puntaje;

    void Start()
    {
        puntaje = GameObject.FindGameObjectWithTag("Player").GetComponent<Puntaje>();
    }

    private void OnTriggerEnter(Collider other)
    {
        puntaje.Cantidad = puntaje.Cantidad + 1;
        Destroy(gameObject);
        ManejarPuntaje.scoreCount++;
    }
}
