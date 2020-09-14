using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireChurch : MonoBehaviour
{
    private Collider particle;
    ParticleSystem m_System;
    ParticleSystem.Particle[] m_Particles;

    void Start()
    {
        particle = GetComponent<Collider>();
    }


    public void OnTriggerEnter(Collider particle)
    {
        if (particle.gameObject.tag == "Player")
        {
            gameObject.GetComponent<ParticleSystem>().Play();
        }
    }
}
