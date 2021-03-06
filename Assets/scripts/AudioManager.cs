using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public ButtonScript buttonScript;

    public static AudioManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume * buttonScript.musicVolume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }
    void Start()
    {
        Play("MainTheme");
    }
    void update()
    {
        foreach (Sound s in sounds)
        {
            s.source.volume = s.volume * buttonScript.musicVolume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }
    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sounds => sounds.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound" + name + "not found!");
            return;
        }
        s.source.Play();
    }
}
