﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{

    public Music music;

    public string radioChangeButtonRight;
    public string radioChangeButtonLeft;
    public string volumeHigherButton;
    public string volumeLowerButton;

    private short _currentRadio = 0;

    [SerializeField]
    short _maxRadios = 2;

    public float volume = 100;

    [SerializeField]
    float _volumeStep = 5;

    [SerializeField]
    float _stickStep = 0.25f;

    [SerializeField]
    GameObject _stick;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(radioChangeButtonRight))
        {
            ChangeRadioRight();
        }
        else if (Input.GetKeyUp(radioChangeButtonLeft))
        {
            ChangeRadioLeft();
        }
        if (Input.GetKeyUp(volumeHigherButton))
        {
            IncreaseVolume();
        }
        else if (Input.GetKeyUp(volumeLowerButton))
        {
            LowerVolume();
        }
    }

    public void ChangeRadioRight()
    {
        ++_currentRadio;
        if (_currentRadio > _maxRadios)
        {
            _currentRadio = 0;
            _stick.transform.localPosition = new Vector3(_stick.transform.localPosition.x - _stickStep * _maxRadios, _stick.transform.localPosition.y, _stick.transform.localPosition.z);
        }
        else
        {
            _stick.transform.localPosition = new Vector3(_stick.transform.localPosition.x + _stickStep, _stick.transform.localPosition.y, _stick.transform.localPosition.z);
        }
        music.ChangeRadio(_currentRadio);
    }

    public void ChangeRadioLeft()
    {
        --_currentRadio;
        if (_currentRadio < 0)
        {
            _currentRadio = _maxRadios;
            _stick.transform.localPosition = new Vector3(_stick.transform.localPosition.x + _stickStep * _maxRadios, _stick.transform.localPosition.y, _stick.transform.localPosition.z);
        }
        else
        {
            _stick.transform.localPosition = new Vector3(_stick.transform.localPosition.x - _stickStep, _stick.transform.localPosition.y, _stick.transform.localPosition.z);
        }
        music.ChangeRadio(_currentRadio);
    }

    public void LowerVolume()
    {
        if(volume > 0)
        {
            volume -= _volumeStep;
        }
        music.ChangeVolume(volume * 0.01f);
    }

    public void IncreaseVolume()
    {
        if (volume < 100)
        {
            volume += _volumeStep;
        }
        music.ChangeVolume(volume * 0.01f);
    }
}
