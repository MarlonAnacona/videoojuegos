using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] private GameObject menuGameOver;
    private VidaPlayer vidaPlayer;
    

    private void Start()
    {
        vidaPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<VidaPlayer>();
    }

    private void Update()
    {
        if (vidaPlayer != null && vidaPlayer.vida <= 0 && !menuGameOver.activeSelf)
        {
            ActivarMenu();
        }
    }

    private void ActivarMenu()
    {
        menuGameOver.SetActive(true);
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
