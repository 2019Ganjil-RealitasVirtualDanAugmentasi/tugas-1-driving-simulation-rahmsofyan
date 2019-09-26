using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputManager))]
public class CarController : MonoBehaviour
{
    // Start is called before the first frame update
    public InputManager IM;
    public List<WheelCollider> throttleWheels;
    public List<WheelCollider> steeringWheels;
    public float strengthCoefficient = 1f;
    public float steerCooeffcient = 1f;
    public float see;
    void Start()
    {
        IM = GetComponent<InputManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (WheelCollider wheel in throttleWheels)
        {
            wheel.motorTorque = strengthCoefficient * Time.deltaTime * IM.throttle;
        }

        foreach(WheelCollider wheel in steeringWheels)
        {
            wheel.steerAngle = steerCooeffcient *  IM.steer ;
            see = steerCooeffcient *  IM.steer ;
        }
    }
}
