using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventHandler : MonoBehaviour
{
    /* Deprecated due to poor communcation on my part */

    [SerializeField]
    int _eventsToCall;

    [SerializeField]
    GameObject _uiPrefab;

    private GameObject _currentUI; //Just here to null check

    [SerializeField]
    Transform _canvasTransform;

    public void CallEvent(TextContents toDisplay, int callerId = -1, bool ignoreCount = false, UnityAction OnClick = null)
    {
        if(_currentUI == null)
        {
            _currentUI = GameObject.Instantiate(_uiPrefab, _canvasTransform);
            _currentUI.GetComponent<TextContentUIDisplay>().Start();
        }
        //TextContentUIDisplay.SetDisplayText(toDisplay, OnClick);

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
