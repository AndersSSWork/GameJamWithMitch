using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewMarkReadInState", menuName = "ScriptableObjects/TextContentActions/MarkReadInState", order = 1)]
public class MarkReadInState : InjectableResponseAction
{
    public override void ExecuteResponseAction(TextContents contents)
    {
        DialogState.hasVisited[contents.id] = true;
    }
}
