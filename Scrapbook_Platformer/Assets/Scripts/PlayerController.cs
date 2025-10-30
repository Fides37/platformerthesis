using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    private float speed = 10f;

    public Camera cam;
    

    // Start is called before the first frame update
    void Start()
    {
        
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
            Debug.Log("hey");
            velocity.x -= speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("yo");
            velocity.x += speed * Time.deltaTime;
        }
        else
        {
            velocity.x = 0;
        }

        return velocity;
    }

    private void CameraMovement()
    {
        cam.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -10);
    }

}
