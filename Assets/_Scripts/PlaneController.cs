using UnityEngine;
using UnityEngine.InputSystem;

public class PlaneController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float rotationSpeed = 60f;

    private float moveInput;
    private float rotateInput;
    private float heightInput;

    public void Height(InputAction.CallbackContext context)
    {
        heightInput = context.ReadValue<float>();
    }
    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<float>();
    }

    public void Rotate(InputAction.CallbackContext context)
    {
        rotateInput = context.ReadValue<float>();
    }

    private void Update()
    {
        transform.position += transform.forward * moveInput * moveSpeed * Time.deltaTime;

        transform.position += Vector3.up * heightInput * moveSpeed * Time.deltaTime;

        transform.Rotate(
            Vector3.up * rotateInput * rotationSpeed * Time.deltaTime
        );
    }
}