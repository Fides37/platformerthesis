using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    private float speed;
    private float jumpForce = 5f;

    public Camera cam;

    private bool canJump;
    private bool isGrounded;
    

    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = PlayerMovement();

        CameraMovement();

    }

    private Vector2 PlayerMovement()
    {
        Vector2 velocity = rb.velocity;

        if (Input.GetKey(KeyCode.A))
        {
            
            velocity.x = -speed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            
            velocity.x = speed;
        }
        else
        {
            velocity.x = 0;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            velocity.y = jumpForce;
        }

        return velocity;
    }

    private void CameraMovement()
    {
        cam.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -10);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Spikes")
        {
            gameObject.transform.position = new Vector2(0, 0);
        }

        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }

}
