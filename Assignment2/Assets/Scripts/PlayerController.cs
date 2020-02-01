using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    /*
		 * Warren Guiles
		 * PlayerController.cs
		 * Assignment 2
		 * This lets you move the player using wasd.
	*/


    public float movementSpeed;

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.Translate(movement * Time.deltaTime * movementSpeed);
    }
}
