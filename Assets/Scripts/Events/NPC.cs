using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private Quaternion _originalRotation;

    void Start()
    {
        Sprite[] textures = Resources.LoadAll<Sprite>("Faces");
        Sprite texture = textures[Random.Range(0, textures.Length)];
        GetComponentInChildren<SpriteRenderer>().sprite = texture;
    }

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
