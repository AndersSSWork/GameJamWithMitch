using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Readme:
 * 
 * This component is placed on a UI manager component.
 * It's parameters are: 
 *      1. the panel holding the dialog text
 *      2. the 3 text items displating title, contents and reponse
 *      3. the display text, which will be dynamic during runtime
 * Functions:
 *      1. Update - sets the panel visibiity and text values
 *      2. OnResponseClick - triggers the after click script and clears displayText
 */
public class TextContentUIDisplay : MonoBehaviour
{
    public TextContents displayText;

    [SerializeField] GameObject panel;

    [SerializeField] Text title;
    [SerializeField] Text content;
    [SerializeField] Text response;

    // Start is called before the first frame update
    void Start()
    {
        
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
        // TODO: trigger after click script

        displayText = null;
    }
}
