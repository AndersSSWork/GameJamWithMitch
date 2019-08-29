using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AssignDialog : MonoBehaviour
{
    [SerializeField] TextContents contents;

    [SerializeField] bool destroyAfterTrigger = true;

    [SerializeField] NPC _npc;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            TextContentUIDisplay.SetDisplayText(contents, _npc);
            if (destroyAfterTrigger)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
