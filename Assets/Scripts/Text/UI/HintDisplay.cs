using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintDisplay : MonoBehaviour
{
    [SerializeField] HintContent _hint;
    public HintContent hint
    {
        get
        {
            return _hint;
        }
        set
        {
            _hint = value;
            updateHintDisplay();
        }
    }

    [SerializeField] Text hintGiverTxt;
    [SerializeField] Text hintContentTxt;

    private void Start()
    {
        if (hint != null)
        {
            updateHintDisplay();
        }
    }

    private void updateHintDisplay()
    {
        hintGiverTxt.text = "Given By: " + hint.hintGiver;
        hintGiverTxt.color = hint.hintColor;
        hintContentTxt.text = hint.hintContent;
        hintContentTxt.color = hint.hintColor;
    }
}
