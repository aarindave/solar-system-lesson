using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    public Transform target; // Current target (Sun or planet)
    public float distance = 40f; // Default distance from target
    public float zoomSpeed = 10f; // Scroll zoom speed
    public float rotationSpeed = 100f; // Orbit rotation speed
    private float currentX = 0f;
    private float currentY = 20f;
    private float minY = -10f;
    private float maxY = 80f;

    void Update()
    {
        // Rotate camera with mouse drag
        if (Mouse.current.rightButton.isPressed)
        {
            currentX += Mouse.current.delta.x.ReadValue() * rotationSpeed * Time.deltaTime;
            currentY -= Mouse.current.delta.y.ReadValue() * rotationSpeed * Time.deltaTime;
            currentY = Mathf.Clamp(currentY, minY, maxY);
        }
        // Zoom with scroll wheel
        float scroll = Mouse.current.scroll.ReadValue().y;
        distance -= scroll * zoomSpeed;
        distance = Mathf.Clamp(distance, 5f, 300f);
    }
}
