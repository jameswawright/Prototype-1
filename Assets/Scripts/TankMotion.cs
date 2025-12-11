using UnityEngine;

public class TankMotion : MonoBehaviour
{
    // Initialize speed variable to control tank movement
    private float speed = 10.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the tank forward continuously
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
    }
}
