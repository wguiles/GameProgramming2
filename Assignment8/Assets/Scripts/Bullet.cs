using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
	 * Warren Guiles
	 * Bullet.cs
	 * Assignment 8
	* This script is handles a basic bullet script that will be fired by 
      the player and the enemies.
 */

public class Bullet : MonoBehaviour
{
    private int direction;
    public float bulletSpeed;

    public void SetDirection(int directionToSet)
    {
        direction = directionToSet;
    }

    private void Update() 
    {
        transform.Translate(new Vector2(direction * bulletSpeed * Time.deltaTime, 0f));
    }
}
