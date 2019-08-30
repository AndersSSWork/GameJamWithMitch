using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour
{
    public static float Volume = 0.4f;
    public static float SFX = 0.4f;

    [SerializeField] Text VolumeTxt;
    [SerializeField] Slider VolumeSld;
    [SerializeField] Text SFXTxt;
    [SerializeField] Slider SFXSld;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    { 
        Volume = VolumeSld.value;
        SFX = SFXSld.value;

        VolumeTxt.text = VolumeSld.value.ToString();
        SFXTxt.text = SFXSld.value.ToString();
    }
}
