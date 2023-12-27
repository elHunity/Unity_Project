using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this value to control the movement speed.

    void Update()
    {
        // Get the horizontal input (left/right arrow keys or A/D keys)
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate the movement vector
        Vector2 movement = new Vector2(horizontalInput, 0f) * moveSpeed;

        // Move the object
        transform.Translate(movement);
    }
}
