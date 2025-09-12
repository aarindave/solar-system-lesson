using UnityEngine;

public class PlanetOrbit : MonoBehaviour
{
    public Transform sun; // Object to orbit around
    public float orbitSpeed = 10f; // Revolution speed
    public float selfRotateSpeed = 50f; // Rotation on its own axis
    public float orbitRadius = 10f; // Distance from sun
    private float angle = 0f;

    void Update()
    {
        // Increment angle for orbit motion
        angle += orbitSpeed * Time.deltaTime;
        float rad = angle * Mathf.Deg2Rad;
        // Circular orbit
        float x = orbitRadius * Mathf.Cos(rad);
        float z = orbitRadius * Mathf.Sin(rad);
        transform.position = new Vector3(x, 0, z) + sun.position;
        // Self rotation
        transform.Rotate(Vector3.up * selfRotateSpeed * Time.deltaTime);
    }
}
