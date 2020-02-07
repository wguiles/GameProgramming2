using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
        /*
	 * Warren Guiles
	 * BulletScript.cs
	 * Assignment 3
	 * This script handles the bullet projectiles that are shot out of 
     the player and the bossNodes. It mainly deals with direction and
     speed that the bullet is traveling.

	 */
    public float bulletSpeed;

    public Vector2 direction;

    private void Update() 
    {
        transform.Translate(direction * bulletSpeed * Time.deltaTime);
    }

    public void SetDirection(Vector2 newDirection)
    {
        direction = newDirection;
    }


}
