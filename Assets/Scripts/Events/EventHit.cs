using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHit : MonoBehaviour
{
    public void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Hit a trigger");
        
    }
}
