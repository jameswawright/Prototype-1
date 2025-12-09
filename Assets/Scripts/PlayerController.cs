using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Initialize speed variable to control vehicle movement
    private float speed = 15.0f;
    // Initialize turnSpeed variable to control vehicle turning
    private float turnSpeed = 25.0f; 
    // Initialise horzontalInput and verticalInput variables to capture player input
    private float horizontalInput;
    private float verticalInput;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // LateUpdate is called once per frame after all Update methods have been called
    void LateUpdate()
    {
        // Capture horizontal and vertical input from player
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // Get horizontal input for turning by rotating around y axis via Vector3.up
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
