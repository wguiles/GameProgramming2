using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    /*
		 * Warren Guiles
		 * Door.cs
		 * Assignment 6 
		 * I put this script on the door to tell the player which type it is in 
         order to switch the player based on which door they enter
	*/
    public enum doorType
    {
        fast,
        small,

        normal
    }

    public doorType type;
}
