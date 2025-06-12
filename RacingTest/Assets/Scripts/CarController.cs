using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class car : MonoBehaviour
{
    public Rigidbody rigid;
    public WheelCollider wheel1, wheel2, wheel3, wheel4;
    public float drivespeed, steerspeed;
    float horizontalInput, verticalInput;

    public TextMeshProUGUI speedText;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        DisplaySpeed();
    }

    void FixedUpdate()
    {
        float motor = verticalInput * drivespeed;

        wheel1.motorTorque = motor;
        wheel2.motorTorque = motor;
        wheel3.motorTorque = motor;
        wheel4.motorTorque = motor;

        wheel1.steerAngle = steerspeed * horizontalInput;
        wheel2.steerAngle = steerspeed * horizontalInput;
    }

    void DisplaySpeed()
    {
        float speed = rigid.velocity.magnitude;
        float speedMph = speed * 1.6f;

        speedText.text = "" + Mathf.RoundToInt(speedMph).ToString() + "MPH";
    }
}