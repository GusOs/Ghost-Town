using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireChurch : MonoBehaviour
{
    private Collider particle;
    private new ParticleSystem particleSystem;
    private bool isPlaying = false;

    public Sound Flames;
    public Sound Ignition;

    void Start()
    {
        particle = GetComponent<Collider>();
        particleSystem = GetComponent<ParticleSystem>();
        particleSystem.Clear();
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !isPlaying)
        {
                particleSystem.Play();
                isPlaying = true;
                AudioManager.Instance.PlaySound(Ignition);
                PauseSound();
                AudioManager.Instance.PlaySound(Flames);
        }
    }

    IEnumerator PauseSound()
    {
        yield return new WaitForSeconds(3);
    }
}