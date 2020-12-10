using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public int dashDistance;
    
    public Rigidbody2D rigidBody;
    public Camera camera;
    
    Vector2 movement;
    Vector2 mousePos;
    Vector2 lookDir;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = camera.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetButtonDown("Jump"))
        {
            Dash();
        }
    }

    void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + movement * moveSpeed * Time.fixedDeltaTime);

        lookDir = mousePos - rigidBody.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;

        rigidBody.rotation = angle;
    }

    void Dash()
    {
        // Needs a lot of work, but the basic idea is there
        // Needs experimenting/refinement, need to find a way to make it follow the player's movement instead of the direction they're looking in
        rigidBody.AddForce(lookDir*dashDistance);  
    }
}
