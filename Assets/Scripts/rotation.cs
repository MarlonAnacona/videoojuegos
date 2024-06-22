using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace MyGame
{
    public class rotation : MonoBehaviour
    {
        // Velocidad de rotación en grados por segundo
        public float rotationSpeed = 90f;
        private int puntuacion;
        public TextMeshProUGUI puntuacionText;

        void Start()
        {
            puntuacion = 0;
        }

        void Update()
        {
            // Rotar el objeto alrededor del eje X
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }

        void Awake()
        {
            Collider2D collider = GetComponent<Collider2D>();
            if (collider != null)
            {
                collider.isTrigger = true;
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            puntuacion++;
            puntuacionText.text = puntuacion.ToString();
            Destroy(collision.gameObject);
        }
    }
}
