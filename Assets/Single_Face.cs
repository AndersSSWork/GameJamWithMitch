using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Single_Face : MonoBehaviour
{
	
    // Start is called before the first frame update
    void Start()
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
