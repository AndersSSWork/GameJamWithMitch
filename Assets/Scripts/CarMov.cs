using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMov : MonoBehaviour
{
    [Range(0, 1)]
    public float acceleration = 1f;
    [Range(0, 1)]
    public float turnSpeed = 0.1f;

    public Rigidbody rigidBody;

//TODO Need to make most of the velocity turn with it as it turns

//TODO if we have time for it, make the camera tilt a bit to the side you turn to, to give the sense of turning

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        if(vertical != 0 || horizontal != 0)
        {
//TODO I'm thinking that the faster you are, the slower it should accelerate, and same with turning
            Vector3 localRight = transform.InverseTransformDirection(transform.right);
            rigidBody.velocity = rigidBody.velocity + -1* rigidBody.transform.right * vertical * acceleration;
            Debug.Log(rigidBody.transform.right);
            rigidBody.angularVelocity = rigidBody.angularVelocity + this.transform.up * horizontal * turnSpeed;
        }

    }
}
