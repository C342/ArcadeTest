using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;        // Your car's transform
    public Vector3 offset = new Vector3(0f, 5f, -10f); // Offset from the car
    public float smoothSpeed = 0.125f; // Smoothing speed

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;

        transform.LookAt(target); // Optional: keep the camera looking at the car
    }
}