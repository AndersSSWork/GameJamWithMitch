using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventHit : MonoBehaviour
{
    [SerializeField]
    TextContents displayText;

    [SerializeField]
    bool hideCount;

    [SerializeField]
    int id;

    [SerializeField]
    NPC attachedNPC;

    public void OnTriggerEnter(Collider collider)
    {
        if(displayText != null && collider.gameObject.tag == "Player")
        {
            UnityAction onClick = new UnityAction(collider.gameObject.GetComponent<CarMov>().EndStop);
            if (attachedNPC != null)
            {
                onClick += attachedNPC.StopStaring;
            }
            attachedNPC.Stare(collider.gameObject.transform.position);
            GetComponentInParent<EventHandler>().CallEvent(displayText, id, hideCount, onClick);
            collider.gameObject.GetComponent<CarMov>().StopCar();
            Destroy(this.gameObject);

        }
    }
}
