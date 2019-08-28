using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintUIDisplay : MonoBehaviour
{
    [SerializeField] GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Toggle Hint Notebook
        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.H))
        {
            panel.SetActive(!panel.activeSelf);
        }

        if (TextContentUIDisplay.getIsOpen())
        {
            panel.SetActive(false);
        }
    }
}
