using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public float resetSpeed = 5f;

    private float yRotation = 0f;
    private Quaternion initialRotation;
    private bool isResetting = false;

    void Start()
    {
        initialRotation = transform.localRotation;
        yRotation = transform.localEulerAngles.y;
    }

    void Update()
    {
        if (Input.GetMouseButton(1) && !isResetting)
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            yRotation += mouseX;

            transform.localRotation = Quaternion.Euler(0f, yRotation, 0f);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            isResetting = true;
        }

        if (isResetting)
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, initialRotation, Time.deltaTime * resetSpeed);

            if (Quaternion.Angle(transform.localRotation, initialRotation) < 0.1f)
            {
                transform.localRotation = initialRotation;
                yRotation = initialRotation.eulerAngles.y;
                isResetting = false;
            }
        }
    }
}