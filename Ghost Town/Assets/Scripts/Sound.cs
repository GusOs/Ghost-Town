﻿using UnityEngine;

[CreateAssetMenu(menuName = "Ghost Town/Sound", fileName = "Sound.asset")]
public class Sound : ScriptableObject
{
    [System.Serializable]
    public enum SoundType
    {
        MUSIC, FX
    }

    //Diferentes opciones del audio
    public SoundType soundType;
    public AudioClip clip;
    [Range(0, 1f)]
    public float volume;
    public bool loop;
}
