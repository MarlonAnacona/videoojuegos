using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class MenuWin : MonoBehaviour
{
    [SerializeField] private GameObject menuWin;
    private Puntaje puntaje;

    private void Start()
    {
        puntaje = GameObject.FindGameObjectWithTag("Player").GetComponent<Puntaje>();
    }

    private void Update()
    {
        if (puntaje != null && puntaje.Cantidad == 5 && !menuWin.activeSelf)
        {
            ActivarMenu();
        }
    }

    private void ActivarMenu()
    {
        menuWin.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MenuInicial(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
}
