using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitarVida : MonoBehaviour
{
    VidaPlayer vidaPlayer;

    public int cantidad;
    public float damageRate;
    float currentDamageRate;

    void Start()
    {
        vidaPlayer = GameObject.FindWithTag("Player").GetComponent<VidaPlayer>(); 
    }

    private void OnTriggerStay(Collider other)
    {
        currentDamageRate += Time.deltaTime;
        if (currentDamageRate > damageRate)
        {
            vidaPlayer.vida += cantidad;
            currentDamageRate = 0.0f;
        }
    }
}
