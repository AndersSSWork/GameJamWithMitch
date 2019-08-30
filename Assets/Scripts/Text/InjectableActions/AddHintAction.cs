using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewAddHintAction", menuName= "ScriptableObjects/TextContentActions/AddHintAction", order = 2)]
public class AddHintAction : InjectableResponseAction
{
    [SerializeField] HintContent hint;

    public override void ExecuteResponseAction(TextContents contents)
    {
        if(DialogState.hints == null)
        {
            DialogState.hints = new List<HintContent>();
        }
        DialogState.hints.Add(hint);
    }
}