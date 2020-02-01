using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHorizontally : IMoveBehaviour
{    
     /*
		 * Warren Guiles
		 * MoveHorizontally.cs
		 * Assignment 2
		 * This is one of the behaviours that the enemy can do. It involves moving left and
         right on the screen.
         
	*/
    int direction = 1;

    public void Movement(int movespeed, GameObject enemy)
    {
        enemy.transform.Translate(new Vector2(movespeed, 0) * direction * Time.deltaTime);

        if (direction > 0 && enemy.transform.position.x >= 9f 
        || direction < 0 &&  enemy.transform.position.x <= -9f)
        {
            ChangeDirection();
        }
    }

    public void ChangeDirection()
    {
        direction *= -1;
    }
}
