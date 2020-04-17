using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

 /*
	 * Warren Guiles
	 * BulletScript.cs
	 * Assignment 11
	 * This is the script that handles bullets the player fires.
     it has code for the bullet moving upwards.
 */
    public float bulletSpeed;


    void Update()
    {
        transform.Translate(new Vector2(0f, bulletSpeed * Time.deltaTime));
    }
}

