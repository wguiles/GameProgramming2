using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
        /*
	 * Warren Guiles
	 * Rotate.cs
	 * Assignment 3
	 * A simple script for rotating objects. I use this 
     to make the boss nodes rotate around the boss.

	 */
    public float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 1f) * Time.deltaTime * rotateSpeed);
    }
}
