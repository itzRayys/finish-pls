using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_player_movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float runSpeed = 1.5f;
    public float speedModifiers = 1f;
    public Rigidbody2D rb;
    public bool isRunning = false;

    Vector2 movement;
    

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (Input.GetButtonDown("sprint")) {
            isRunning = true;
        }
        if (Input.GetButtonUp("sprint"))
        {
            isRunning = false;
        }
    }
    void FixedUpdate()
    {
        if (isRunning)
        {
            rb.MovePosition(rb.position + movement * moveSpeed * runSpeed *
            speedModifiers * Time.deltaTime);
        }
        else
        {
            rb.MovePosition(rb.position + movement * moveSpeed * speedModifiers * 
                Time.deltaTime);
        }
    }
}
