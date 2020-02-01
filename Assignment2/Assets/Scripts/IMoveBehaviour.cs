using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMoveBehaviour
{

    /*
		 * Warren Guiles
		 * IMoveBehaviour.cs
		 * Assignment 2
		 * the interface that the three movement behaviours for the enemies inherit from.
         It contains a method for movement that passes in a speed, and a gameObject to move

	*/
    void Movement(int moveSpeed, GameObject enemy);

}
