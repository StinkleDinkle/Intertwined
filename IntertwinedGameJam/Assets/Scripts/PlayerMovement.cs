using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        restart();
    }

    void restart()
    {
        if(Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("Level1");
        }
    }

    private void FixedUpdate() 
    {
    rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);    
    }
}