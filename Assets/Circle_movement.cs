using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    public float moveSpeed = 5.1333f; 
    public float jumpForce = 5.1333f;

    public Rigidbody2D rb;
    private bool isGrounded;


    

    void OnCollisionEnter2D(Collision2D collision)
    {
        // You can add collision logic here if needed
    }

    void Update()
    {
        {
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate the movement vector
        Vector2 movement = new Vector2(horizontalInput, 0f) * moveSpeed * Time.deltaTime;

        // Move the object
        transform.Translate(movement);
        }


        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)

    {
        isGrounded = false;
        GetComponent<Rigidbody2D>().AddForce(new Vector3(0,500,0));
    }

    }

}
