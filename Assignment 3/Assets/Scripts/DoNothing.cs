using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNothing : INodeBehaviour
{
    /*
	 * Warren Guiles
	 * DoNothing.cs
	 * Assignment 3
	 * This is one of the behaviours that are used by the BossNodes to dictate actions/attacks.
       This one specifically does nothing and is what the nodes start with.
	 */

    public void attack(GameObject nodeObject)
    {
        Debug.Log("I'm not gonna do anything right now");
    }
}
