using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class EfectoSonido : MonoBehaviour
{
    private AudioSource audioSource;
    private VidaPlayer vidaPlayer;

    float damageSoundRate = 0.5f;
    float currentDamageSoundRate;

    private void Start()
    {
        vidaPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<VidaPlayer>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (vidaPlayer != null && vidaPlayer.vida > 0)
        {
            currentDamageSoundRate += Time.deltaTime;

            if (currentDamageSoundRate > damageSoundRate)
            {
                audioSource.Play();
                currentDamageSoundRate = 0.0f;
            }
        }
    }

}
