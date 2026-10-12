using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset = new Vector3(0f, 1.5f, -3f);
    [SerializeField] private float smoothSpeed = 5f;

    private void LateUpdate()
    {
        Vector3 targetPosition = target.position + target.TransformDirection(offset);

        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition,
            smoothSpeed * Time.deltaTime
        );

        transform.LookAt(target);
    }
}