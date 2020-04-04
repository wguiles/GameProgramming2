using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	/*
		 * Warren Guiles
		 * BulletScript
		 * Assignment 9
		 * This is a script I attach to the bullet object that allows
         it to move every frame.
	*/

public class BulletScript : MonoBehaviour
{
    public float bulletSpeed;

   private void Update() 
   {
       transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
   }
}
