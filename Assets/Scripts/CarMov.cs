using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMov : MonoBehaviour
{
    [Range(0, 1)]
    public float acceleration = 1f;
    [Range(0, 1)]
    public float turnSpeed = 0.1f;

    public float maxSpeed = 30;

    private Rigidbody _rigidBody;

    public void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    public float _currentSpeed = 0;

//TODO if we have time for it, make the camera tilt a bit to the side you turn to, to give the sense of turning

    // Update is called once per frame
    void Update()
    {

        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        if(horizontal != 0)
        {
            this.transform.Rotate(_rigidBody.transform.up, turnSpeed * horizontal);

        }
        if (vertical != 0)
        {
            //TODO I'm thinking that the faster you are, the slower it should accelerate, and same with turning

            _currentSpeed += acceleration * vertical;
            if(_currentSpeed > maxSpeed && _currentSpeed > 0)
            {
                _currentSpeed = maxSpeed;
            }
            else if(_currentSpeed < 0 && _currentSpeed < maxSpeed * -1)
            {
                _currentSpeed = maxSpeed * -1;
            }
            _rigidBody.velocity = _rigidBody.transform.right * _currentSpeed * -1;
        }
        else
        {
            _currentSpeed = _rigidBody.velocity.x;// _currentSpeed > 0 ? _rigidBody.velocity.x : _rigidBody.velocity.x * -1;
        }
    }
}
