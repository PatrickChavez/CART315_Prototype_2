using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Code by Brackeys
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }

}
