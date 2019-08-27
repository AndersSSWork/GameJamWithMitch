using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private Quaternion _originalRotation;

    public void Stare(Vector3 target)
    {
        _originalRotation = this.transform.rotation;
        this.transform.LookAt(target);
    }

    public void StopStaring()
    {
        this.transform.rotation = _originalRotation;
    }
}
