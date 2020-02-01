using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards :  IMoveBehaviour
{

     /*
		 * Warren Guiles
		 * MoveTowards.cs
		 * Assignment 2
		 * This is one of the behaviours that the enemy can do. It involves moving towards 
         the player
         
	*/

    private Transform player;

    public void Movement(int speed, GameObject enemy)
    {
        //Move in a straight line towards the player

        

        if (GameObject.Find("Player") != null)
        {
            player = GameObject.Find("Player").transform;
            enemy.transform.position = Vector2.MoveTowards(enemy.transform.position, player.transform.position,  speed * Time.deltaTime);
        }

    }

     public void ChangeDirection()
    {
        return;
        //do nothing - pusuing enemies do not change directions
    }
}
