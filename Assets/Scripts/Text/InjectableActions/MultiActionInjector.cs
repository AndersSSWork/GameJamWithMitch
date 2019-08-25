using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewMultiActionInjector", menuName = "ScriptableObjects/TextContentActions/MultiActionInjector", order = 0)]
public class MultiActionInjector : InjectableResponseAction
{
    [SerializeField] InjectableResponseAction[] actions;

    public override void ExecuteResponseAction(TextContents contents)
    {
        foreach (InjectableResponseAction action in actions)
        {
            action.ExecuteResponseAction(contents);
        }
    }
}
