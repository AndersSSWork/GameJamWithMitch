using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseMaterialAssigner : MonoBehaviour
{
    public Material newMat;

    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer[] ToGiveMat = this.GetComponentsInChildren<MeshRenderer>();
        if(ToGiveMat != null)
        {
            foreach(MeshRenderer SingleMesh in ToGiveMat)
            {
                SingleMesh.material = newMat;
            }
        }
        RandomHouse[] ToSetFace = this.GetComponentsInChildren<RandomHouse>();
        if(ToSetFace != null)
        {
            foreach(RandomHouse SingleHouse in ToSetFace)
            {
                SingleHouse.SetFace();
            }
        }
    }

}
