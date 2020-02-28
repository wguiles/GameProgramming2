using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalEnemy : GameCharacter
{

         /*
	 * Warren Guiles
	 * VerticalEnemy.cs
	 * Assignment 6 
	 * This is a variation of the enemy that gets spawned 
     by the factory. This version moves back and forth vertically
*/
        public float speed;
    private float direction = 1f;

    public float yLimitBottom;

    public float yLimitTop;

    public override void SetPosition(Vector2 newPos)
    {
        transform.position = newPos;

        yLimitBottom = newPos.y - 3;

        yLimitTop = newPos.y + 3;


    }

    public override void Die()
    {
        Destroy(gameObject);
    }

    public override void Move()
    {
        transform.Translate(new Vector2(0f, speed * Time.deltaTime * direction));

        if (transform.position.y > yLimitTop)
        {
            transform.position = new Vector2(transform.position.x, yLimitTop);
            ChangeDirection();
        }
        else if (transform.position.y < yLimitBottom)
        {
            transform.position = new Vector2(transform.position.x, yLimitBottom);
            ChangeDirection();            
        }
    }

    private void Update() 
    {
        Move();
    }

    public override void ActivateAbility()
    {
        direction = 0;

        while (direction == 0)
        {
            direction = (int)Random.Range(-1,2);
        }
    }

    public void ChangeDirection()
    {
        direction *= -1f;
    }
}
