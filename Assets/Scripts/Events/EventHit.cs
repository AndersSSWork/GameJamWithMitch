using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHit : MonoBehaviour
{
    [SerializeField]
    TextContents displayText;

    [SerializeField]
    bool hideCount;

    [SerializeField]
    int id;

    public void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Hit a trigger");
        if(displayText != null)
        {
            GetComponentInParent<EventHandler>().CallEvent(displayText, id, hideCount);
            collider.gameObject.GetComponent<CarMov>().StopCar();
            Debug.Log(collider.gameObject.tag);
            Destroy(this.gameObject);
        }
    }
}
