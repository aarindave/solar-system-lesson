using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxMovement : MonoBehaviour
{
    public float rotationSpeed = 5f; // Adjust speed in the Inspector

    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotationSpeed);
    }
}
