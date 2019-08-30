using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public void Start()
    {
        
        GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("MusicVolume") * GetComponent<AudioSource>().volume;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
