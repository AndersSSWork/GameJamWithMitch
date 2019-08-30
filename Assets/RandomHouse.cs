using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomHouse : MonoBehaviour
{
      public GameObject HUD;

    public bool DontRandomize = false;
    public Texture2D specificTexture = null;

      public void SetFace()
    {
        _AssignFace();
        if (!DontRandomize)
        {
            Texture2D[] textures = Resources.LoadAll<Texture2D>("Houses");
            Texture2D texture = textures[Random.Range(0, textures.Length)];
            HUD.GetComponent<Renderer>().material.mainTexture = texture;
        }
        else
        {
            Debug.Log("Setting texture");
            HUD.GetComponent<Renderer>().material.mainTexture = specificTexture;
        }
     }

    private void _AssignFace()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector2[] uvSingleFace = {
        new Vector2(0, 1),
        new Vector2(1, 1),
        new Vector2(0, 0),
        new Vector2(1, 0),



        new Vector2(-1, -1),
        new Vector2(-1, -1),
        new Vector2(-1, -1),
        new Vector2(-1, -1),


        new Vector2(-1, -1),
        new Vector2(-1, -1),
        new Vector2(-1, -1),
        new Vector2(-1, -1),

        new Vector2(-1, -1),
        new Vector2(-1, -1),
        new Vector2(-1, -1),
        new Vector2(-1, -1),

        new Vector2(-1, -1),
        new Vector2(-1, -1),
        new Vector2(-1, -1),
        new Vector2(-1, -1),

        new Vector2(-1, -1),
        new Vector2(-1, -1),
        new Vector2(-1, -1),
        new Vector2(-1, -1)
    };
        mesh.uv = uvSingleFace;
    }
}
