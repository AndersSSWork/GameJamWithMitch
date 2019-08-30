using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 
 * DOES NOT WORK
 * 
 */
[CreateAssetMenu(fileName = "NewPlaySoundInjectable", menuName = "ScriptableObjects/TextContentActions/PlaySoundInjectable", order = 3)]
public class PlaySoundInjectable : InjectableResponseAction
{
    [SerializeField] AudioSource sound;

    public override void ExecuteResponseAction(TextContents contents)
    {
        sound.PlayDelayed(0.4f);
    }
}
