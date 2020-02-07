using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour, IBossNode
{
    /*
	 * Warren Guiles
	 * BossBehaviour.cs
	 * Assignment 3
	 * This is one of the observer classes that recieves information from 
     the subject. This script receives the health from the Subject,
     and changes the boss's behaviour based on how much the boss has been damaged,
     mainly dealing with movement speed and direction

	 */
    public float moveSpeed;

    public float xLimitLeft;
    public float xLimitRight;

    public float yLimitTop;
    public float yLimitBottom;

    private Vector2 direction = new Vector2 (1f, 0f);

    
    void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime * direction);

        if (direction.x >= 1 && transform.position.x >= xLimitRight) 
        {
            ChangeXDirection();
            transform.position = new Vector3(xLimitRight, transform.position.y);
        }
        else if (direction.x <= -1 && transform.position.x <= xLimitLeft)
        {
            ChangeXDirection();
            transform.position = new Vector3(xLimitLeft, transform.position.y);
        }

        if (direction.y >= 1 && transform.position.y >= yLimitTop)
        {
            ChangeYDirection();
            transform.position = new Vector3(transform.position.x, yLimitTop);
        }
        else if (direction.y <= -1f && transform.position.y <= yLimitBottom)
        {
            ChangeYDirection();
            transform.position = new Vector3(transform.position.x, yLimitBottom);
        }
    }

    public GameObject GetGameObject()
    {
        return gameObject;
    }

    public void updateBehaviour(int healthRemaining)
    {
        if (healthRemaining <= 50 && healthRemaining > 30)
        {
            moveSpeed = 5f;
        }
        else if (healthRemaining <= 30 && direction.y == 0f)
        {
            direction = new Vector2(direction.x, 1);
        }
    }

    private void ChangeXDirection()
    {
        direction *= new Vector2(-1f, 1f);
    }

    private void ChangeYDirection()
    {
        direction *= new Vector2(1f, -1f);
    }
}
