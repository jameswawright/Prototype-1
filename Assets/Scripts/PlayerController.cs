using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Initialize speed variable to control vehicle movement
    public float speed = 15f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // LateUpdate is called once per frame after all Update methods have been called
    void LateUpdate()
    {
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
