using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHit : MonoBehaviour
{
    [SerializeField]
    TextContents displayText;

    public void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Hit a trigger");
        if(displayText != null)
        {
            GetComponentInParent<EventHandler>().CallEvent(displayText);
            Destroy(this.gameObject);
        }
    }
}
