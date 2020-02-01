using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVertically : IMoveBehaviour
{

    /*
		 * Warren Guiles
		 * MoveVertically.cs
		 * Assignment 2
		 * This is one of the behaviours that the enemy can do. It involves moving top to bottom on the screen.
         
	*/

    int direction = 1;

    public void Movement(int movespeed, GameObject enemy)
    {
        enemy.transform.Translate(new Vector2(0, movespeed) * direction * Time.deltaTime);

        if (direction > 0 && enemy.transform.position.y >= 6f 
        || direction < 0 &&  enemy.transform.position.y <= -4f)
        {
            ChangeDirection();
        }
       
    }

    public void ChangeDirection()
    {
        direction *= -1;
    }
}
