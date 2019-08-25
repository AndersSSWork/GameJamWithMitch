using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHintAction : InjectableResponseAction
{
    HintContent hint;

    public override void ExecuteResponseAction(TextContents contents)
    {
        if(DialogState.hints == null)
        {
            DialogState.hints = new List<HintContent>();
        }
        DialogState.hints.Add(hint);
    }
}
