using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private Quaternion _originalRotation;

    //private static List<Sprite> _textures;

        /*
    void Start()
    {
        
        if (_textures == null) {
            _textures = new List<Sprite>(Resources.LoadAll<Sprite>("Faces"));
        }
        if (_textures != null && _textures.Count > 0)
        {
            int chosenTexture = Random.Range(0, _textures.Count);
            Sprite texture = _textures[chosenTexture];
            GetComponentInChildren<SpriteRenderer>().sprite = texture;
            _textures.RemoveAt(chosenTexture);
        }
        
    }
    */

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
