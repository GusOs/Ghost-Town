using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireChurch : MonoBehaviour
{
    private Collider particle;
    private new ParticleSystem particleSystem;
    private bool isPlaying = false;

    public Sound Flames;

    void Start()
    {
        particle = GetComponent<Collider>();
        particleSystem = GetComponent<ParticleSystem>();
        particleSystem.Clear();
    }

    //Si colisiona, activar las particulas y reproducir sonido
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !isPlaying)
        {
                particleSystem.Play();
                isPlaying = true;
                AudioManager.Instance.PlaySound(Flames);
        }
    }
}