using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // آبجکتی که دوربین باید دنبالش کنه
    public float smoothSpeed = 0.125f; // نرمی حرکت
    public Vector3 offset; // فاصله دوربین با پلیر

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;
    }
}
