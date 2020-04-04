using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	/*
		 * Warren Guiles
		 * EnemyScript
		 * Assignment 9
		 * This is the top level interface for the state machine. It's
         what all the concrete states inherit from. It has a method
         to move the enemy and a method for actions it takes.
	*/
public interface EnemyState
{

    void Move(GameObject Enemy);

    void Action(GameObject Enemy);

}
