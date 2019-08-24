using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMov : MonoBehaviour
{
    public float speed = 1f;

    private Rigidbody _rigidBody;

    public void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        if(vertical != 0 || horizontal != 0)
        {
            _rigidBody.velocity = _rigidBody.velocity + -1* this.transform.right * vertical * speed + this.transform.forward * horizontal * speed;
            Debug.Log(_rigidBody.velocity);
        }
    }
}
