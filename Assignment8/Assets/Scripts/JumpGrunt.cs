using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
	 * Warren Guiles
	 * JumpGrunt.cs
	 * Assignment 8
	* This script handles one of the enemies that uses the abstract enemy template. It's
    attack method uses the method jump to jump every few seconds.
 */
public class JumpGrunt : AbstractEnemy
{
    public float JumpRate;
    public float jumpHeight;

    private float currentTimer = 0f;

    public override void Jump()
    {
        currentTimer += Time.deltaTime;

        if (currentTimer >= JumpRate)
        {
            currentTimer = 0f;
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
        }
    }

    public override void Shoot()
    {

    }
}
