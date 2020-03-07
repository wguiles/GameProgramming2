using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinDetection : MonoBehaviour
{

/*
    * Warren Guiles
    * PlayerBehaviour.cs
    * Assignment7
    * This is a script I attached to the last platofrm of the game that
    lets the player know that they've reached the final destination
*/    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "Player")
        {
            UIManager.instance.ActivateWinPanel();
        }
    }
}
