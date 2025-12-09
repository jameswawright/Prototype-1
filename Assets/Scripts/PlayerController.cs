using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Initialize speed variable to control vehicle movement
    public float speed = 15f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
