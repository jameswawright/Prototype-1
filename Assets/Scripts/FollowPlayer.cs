using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Initialize reference to the player object
    public GameObject player;

    // Initialise offset to position the camera behind and above the player
    private Vector3 offset = new Vector3(0, 5, -10);


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Follow the player's position
        transform.position = player.transform.position + offset;
    }
}
