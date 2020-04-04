﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

        	/*
		 * Warren Guiles
		 * GunScript
		 * Assignment 9
		 * This script handles looking around for the player. This is a modified
         script from a Brackey's tutorial.
	*/
    public Transform playerBody;
   
    public float mouseSensitivity = 100f;

    float xRotation = 0f;

     private void Start() 
     {
         Cursor.lockState = CursorLockMode.Locked;
     }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}