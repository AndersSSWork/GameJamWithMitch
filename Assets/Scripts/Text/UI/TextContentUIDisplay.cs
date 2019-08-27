using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/*
 * Readme:
 * 
 * This component is placed on a UI manager component.
 * It's parameters are: 
 *      1. the panel holding the dialog text
 *      2. the 3 text items displating title, contents and reponse
 *      3. the display text, which will be dynamic during runtime, set by SetDisplayText.
 *      
 * Private Functions:
 *      1. Update - sets the panel visibiity and text values
 *      2. OnResponseClick - triggers the after click script and clears displayText
 *      
 * Public Functions
 *      1. SetDisplayText - sets the displayText, used to clear the display text in OnResponseClick
 */
public class TextContentUIDisplay : MonoBehaviour
{
    private static TextContentUIDisplay instance;

    [SerializeField] TextContents displayText;

    [SerializeField] GameObject panel;

    [SerializeField] Text title;
    [SerializeField] Text content;
    [SerializeField] Text response;

    private static UnityAction _npcHead;

    // Start is called before the first frame update
    public void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(displayText != null)
        {
            panel.SetActive(true);

            title.text = displayText.title;
            content.text = displayText.content;
            response.text = displayText.response;
        }
        else
        {
            panel.SetActive(false);
        }
    }

    public void OnResponseClick()
    {
        displayText.ExecuteAction();
        if(_npcHead != null)
        {
            _npcHead.Invoke();
        }
        Destroy(this.gameObject);
        //SetDisplayText(null);
    }

    public static void SetDisplayText(TextContents contents, UnityAction npc = null)
    {
        if (instance != null)
        {
            instance.displayText = contents;
            _npcHead = npc;
        }
    }
}
