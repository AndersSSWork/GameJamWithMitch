using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource radio;
    public AudioClip[] music;


    public void Start()
    {
        float originalVolume = radio.volume;
        radio.volume = PlayerPrefs.GetFloat("MusicVolume") * originalVolume;

        radio.clip = music[0];
        radio.Play();
    }

    public void ChangeRadio(int newSong)
    {
        radio.Stop();
        radio.clip = music[newSong];
        radio.Play();
    }

    public void ChangeVolume(float newVolume)
    {
        radio.volume = newVolume;
    }
}
