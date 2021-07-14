using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cowboy : MonoBehaviour
{
    public float upForce; //Upward force of the "flap".
    private bool isDead = false; //Has the player collided with a wall?

    private Animator anim; //Reference to the Animator component.
    private Rigidbody2D rb2d; //Holds a reference to the Rigidbody2D component of the bird.

    public float scrollSpeed = -1.5f;

    void Start()
    {
        Screen.orientation = ScreenOrientation.Landscape;

        //Get reference to the Animator component attached to this GameObject.
        anim = GetComponent<Animator>();
        //Get and store a reference to the Rigidbody2D attached to this GameObject.
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Screen.orientation = ScreenOrientation.Landscape;

        //Don't allow control if the bird has died.
        if (isDead == false)
        {
            //Look for input to trigger a "flap".
            if (Input.GetMouseButtonDown(0))
            {
                //...tell the animator about it and then...
                anim.SetTrigger("Jump");
                //...zero out the birds current y velocity before...
                //    rb2d.velocity = Vector2.zero;
                //    new Vector2(rb2d.velocity.x, 0);
                //..giving the bird some upward force.
                rb2d.AddForce(new Vector2(scrollSpeed, upForce));
                // if (Input.GetMouseButtonUp(0))
                // {
                //     rb2d.velocity = new Vector2(scrollSpeed, 0);
                // }
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // Zero out the bird's velocity
        if (other.gameObject.CompareTag("Colum"))
        {
            rb2d.velocity = Vector2.zero;
            // If the bird collides with something set it to dead...

            anim.SetTrigger("Die");

            isDead = true;
            GameControl.instance.BirdDied();
        }
        //...tell the Animator about it...


        //...and tell the game control about it.
    }
}