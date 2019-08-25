using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    [SerializeField]
    int _eventsToCall;

    [SerializeField]
    GameObject _uiPrefab;

    private GameObject _currentUI; //Just here to null check

    [SerializeField]
    Transform _canvasTransform;

    public void CallEvent(TextContents toDisplay, int callerId = -1, bool ignoreCount = false)
    {
        if(_currentUI == null)
        {
            _currentUI = GameObject.Instantiate(_uiPrefab, _canvasTransform);
        }
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
