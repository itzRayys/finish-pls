using System;
using UnityEngine;
using UnityEngine.Audio;

public class Script_audioManager : MonoBehaviour
{
    public static Script_audioManager Instance;

    public Script_sound[] sounds;

    private void Awake()
    {
        foreach (Script_sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.panStereo = s.stereoPan;
        }
    }

    private void OnEnable()
    {
        Script_itemCoin.coinCollected += playCoinSound;
        Script_itemRedGem.redGemCollected += playRedGemSound;
    }

    private void OnDisable()
    {
        Script_itemCoin.coinCollected -= playCoinSound;
        Script_itemRedGem.redGemCollected -= playRedGemSound;

    }

    public void playCoinSound()
    {
        Play("coin pickup");
    }

    public void playRedGemSound()
    {
        Play("red gem pickup");
    }

    public void Play(string name)
    {
        Script_sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }


}
