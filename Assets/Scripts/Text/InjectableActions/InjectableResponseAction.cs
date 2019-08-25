using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InjectableResponseAction : ScriptableObject
{
    public virtual void ExecuteResponseAction(TextContents contents)
    {
        Debug.Log("InjectableResponseAction::ExecuteResponseAction " + contents.id);
    }
}
