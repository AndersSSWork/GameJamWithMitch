using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollController : MonoBehaviour
{
    [SerializeField] float scrollSensitivity = 5f;

    [SerializeField] Scrollbar scrollbar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (scrollbar != null)
        {
            scrollbar.value = scrollbar.value + Input.GetAxis("Vertical") * Time.deltaTime * scrollSensitivity;
        }
    }
}
