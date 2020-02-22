using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowStun : Ball
{
       /*
    * Warren Guiles
    * SlowStun.cs
     * Assignment 5
    * This is a ball that inherits from the super ball class
    that is created through the factory pattern. This ball is moves very slow,
    but is worth a lot of points. It will also stun the player if the player
    gets hit by it.
    */

    public override void Ability()
    {
        //stun the player
    }

    public override void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Wall")
        {
            if (moveDirection.x != 0)
            {
                SetDirection(new Vector2(moveDirection.x * -1f, moveDirection.y));
            }
        }
        if (other.gameObject.tag == "GoalBumper")
        {
            if (moveDirection.y != 0)
            {
                SetDirection(new Vector2(moveDirection.x, moveDirection.y * -1f));
            }
        }

        if (other.gameObject.tag == "Player")
        {
            PlayerController player = other.gameObject.GetComponent<PlayerController>();

            if (player != null)
            {
                player.FreezePlayer();
                Destroy(gameObject);
            }
            else
            {
                SetDirection(new Vector2(moveDirection.x, moveDirection.y * -1f));
            }

            // MoveLeftAndRight opponent = other.gameObject.GetComponent<MoveLeftAndRight>();

            // if (opponent != null)
            // {
            //     opponent.Stun();
            //     Destroy(gameObject);
            // }
            
            

        }
    }
}
