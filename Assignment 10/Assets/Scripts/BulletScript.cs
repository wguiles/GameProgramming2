using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
	* Warren Guiles
	 * BulletScript
	 * Assignment 10
	 * This is a basic script that has a method for setting it's velocity
     and moving it based on a set speed
 */

public class BulletScript : MonoBehaviour
{
    public float bulletSpeed;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void SetVelocity(Vector2 newVelocity)
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
        }

        rb.velocity = newVelocity * bulletSpeed;
    }
}
