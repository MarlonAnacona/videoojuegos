using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    // Velocidad de rotación en grados por segundo
    public float rotationSpeed = 90f;

    // Update is called once per frame
    void Update()
    {
        // Rotar el objeto alrededor del eje X
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
