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


    // Initialize references to main and side cameras
    public Camera mainCamera;
    public Camera sideCamera;
    // Define key to switch between cameras
    public KeyCode switchKey;

    // Initialize inputID to differentiate between multiple players (if needed)
    public string inputID;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // LateUpdate is called once per frame after all Update methods have been called
    void LateUpdate()
    {
        // Capture horizontal and vertical input from player
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        verticalInput = Input.GetAxis("Vertical" + inputID);

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // Get horizontal input for turning by rotating around y axis via Vector3.up
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        // Switch between main and side cameras when the switch key is pressed
        if (Input.GetKeyDown(switchKey))
        {
            // Toggle camera enabled states
            mainCamera.enabled = !mainCamera.enabled;
            sideCamera.enabled = !sideCamera.enabled;
        }
    }
}
