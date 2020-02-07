using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBossNode
{
    /*
	 * Warren Guiles
	 * IBossNode.cs
	 * Assignment 3
	 * This is the interface for the observer classes. It contains a method
     for receiving the information from the subject in the form of how much
     health the boss has left. There's also a method to return the gameObject
     attached to the specific bossNode
	 */

    void updateBehaviour(int healthReamining);

    GameObject GetGameObject();
}
