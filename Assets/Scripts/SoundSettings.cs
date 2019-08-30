using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSettings : MonoBehaviour
{
    public Slider musicVolume;
    public Slider crashVolume;

    void Start()
    {
        _ChangeVolumes(1, 1);
    }

    public void ReadSliders()
    {
        _ChangeVolumes(musicVolume.value, crashVolume.value);
    }

    private void _ChangeVolumes(float music, float crash)
    {
        PlayerPrefs.SetFloat("MusicVolume", music);
        PlayerPrefs.SetFloat("CrashVolume", crash);
    }
}
