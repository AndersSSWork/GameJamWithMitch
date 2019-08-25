using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMov : MonoBehaviour
{
    [Range(0, 10)]
    public float acceleration = 1f;
    [Range(0, 1)]
    public float turnSpeed = 0.1f;

    //How much the turn is physics based compared to just rotating the body along with its velocity
    //Higher is more physics
    [Range(0, 1)]
    public float turnPhysicsPercentage;

    [SerializeField][Range(0, 1)]
    float _turnAdjusting = 0.8f; //How much it retains the sideways physics, higher = more physics

    public float maxSpeed = 30;

    private int _groundsTouching = 0;
    private bool _isBackingUp = false;

    private Rigidbody _rigidBody;

    public void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

//TODO if we have time for it, make the camera tilt a bit to the side you turn to, to give the sense of turning

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        if (horizontal != 0)
        {
            if (turnPhysicsPercentage != 1)
            {
                if (_groundsTouching > 0)
                {
                    this.transform.Rotate(_rigidBody.transform.up, turnSpeed * horizontal * (1 - turnPhysicsPercentage));
                }
            }
            if (turnPhysicsPercentage != 0)
            {
                _rigidBody.angularVelocity = _rigidBody.angularVelocity * turnSpeed * turnPhysicsPercentage;
            }
        }
        if (vertical != 0 && _groundsTouching > 0)
        {
            //TODO I'm thinking that the faster you are, the slower it should accelerate, and same with turning
            
            Vector3 attemptedSpeed = _rigidBody.velocity + _rigidBody.transform.right * acceleration * vertical * -1;
            if(!(attemptedSpeed.magnitude > maxSpeed))
            { 
                _rigidBody.velocity = attemptedSpeed;
            }
        }
        if(_rigidBody.angularVelocity.magnitude > 0)
        {
            //This ensures that it doesn't slide to the side too much
            //_rigidBody.angularVelocity = _rigidBody.angularVelocity * 0.9f;
        }
        if (_groundsTouching > 0 && (_rigidBody.velocity.z != 0 || _rigidBody.velocity.x != 0) && vertical >= 0)
        {
            float potBack = Vector3.Dot(_rigidBody.velocity, _rigidBody.transform.right) > 0 ? 1 : -1;
            Vector3 adjustedVelocity = (1 - _turnAdjusting) * _rigidBody.transform.right * (new Vector2(_rigidBody.velocity.x, _rigidBody.velocity.z).magnitude) * potBack;
            _rigidBody.velocity = new Vector3(adjustedVelocity.x, _rigidBody.velocity.y, adjustedVelocity.z) + _rigidBody.velocity * _turnAdjusting;
        }
    }

    public void StopCar()
    {
        _rigidBody.velocity = new Vector3(0, 0, 0);
    }


    public void OnCollisionEnter()
    {
        ++_groundsTouching;
    }

    public void OnCollisionExit()
    {
        --_groundsTouching;
    }
}
