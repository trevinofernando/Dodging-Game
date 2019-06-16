using UnityEngine.Audio;
using System;
using System.Collections;
using UnityEngine;


public class AudioManager : MonoBehaviour
{

    public AudioMixerGroup audioMixer;
    public Sound[] sounds; //array with all sounds for the game

    void Awake() //runs before start method
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            s.source.outputAudioMixerGroup = audioMixer;
        }

    }

    IEnumerator Start()
    {
        yield return new WaitForFixedUpdate(); //Wait until everything is loaded before playing the music
        Play("MainTheme");
    }

    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name); //find the sound with the given name in the array
        if (s == null)
        {
            Debug.LogWarning("Sound " + name + " not found.");
            return;
        }
        else
        {
            s.source.Play();
        }
    }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name); //find the sound with the given name in the array
        if (s == null)
        {
            Debug.LogWarning("Sound " + name + " not found.");
            return;
        }
        else
        {
            s.source.Stop();
        }
    }
}
