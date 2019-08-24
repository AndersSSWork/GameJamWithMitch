using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    [SerializeField]
    int _eventsToCall;



    public void CallEvent(TextContents toDisplay, int callerId = -1, bool ignoreCount = false)
    {
        TextContentUIDisplay.SetDisplayText(toDisplay);

        if (!ignoreCount)
        {
            _eventsToCall -= 1;
            if(_eventsToCall <= 0)
            {
#warning Victory condition here
            }
        }
    }
}
