using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomHouse : MonoBehaviour
{
      public GameObject HUD;
     
      void Start() {
         
         Texture2D[] textures = Resources.LoadAll<Texture2D>("Houses");
         Texture2D texture = textures[Random.Range(0, textures.Length)];
         HUD.GetComponent<Renderer>().material.mainTexture = texture;
     }
}
