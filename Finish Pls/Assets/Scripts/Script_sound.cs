using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Script_sound
{
    public string name;

    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;
    [Range(-1f, 1f)]
    public float stereoPan;


    [HideInInspector]
    public AudioSource source;
}
