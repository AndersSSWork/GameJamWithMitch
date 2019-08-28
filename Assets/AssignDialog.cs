using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignDialog : MonoBehaviour
{
    [SerializeField] TextContents contents;

    [SerializeField] bool destroyAfterTrigger = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            TextContentUIDisplay.SetDisplayText(contents);
            if (destroyAfterTrigger)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
