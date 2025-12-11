using UnityEngine;

public class VehicleMotion : MonoBehaviour
{
    // Initialize forward speed variable
    private float forwardSpeed = 20f;
    // Initialize maximum steering angle for drifting effect
    private float maxSteerAngle = 30f;
    // Initialize steering change speed
    private float steerChangeSpeed = 1.5f;

    // Initialize target steering angle
    private float targetSteerAngle = 0f;
    // Initialize current steering angle
    private float currentSteerAngle = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Forward movement
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);

        // Occasionally pick a new random steering target (drunk decision)
        if (Random.value < 0.05f)  // 5% chance each frame
        {
            targetSteerAngle = Random.Range(-maxSteerAngle, maxSteerAngle);
        }

        // Smoothly wobble toward the target steering angle (slow delayed reactions) - lerp slowly transitions between two values over time
        currentSteerAngle = Mathf.Lerp(currentSteerAngle, targetSteerAngle, Time.deltaTime * steerChangeSpeed);

        // Apply rotation as steering drift
        transform.Rotate(Vector3.up, currentSteerAngle * Time.deltaTime);
    }
}
