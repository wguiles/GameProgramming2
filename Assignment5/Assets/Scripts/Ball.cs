using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Warren Guiles
 * Ball.cs
 * Assignment 5
 * This is the base class for the thing that gets created in the factory. 
 In this specific case, it's a ball that the play can fire in order to 
 try to reach a goal. It contains modifications to speed and direction,
 as well as an abstract ability method and collision handling with the player.
 */

public class Ball : MonoBehaviour
{
    
    [SerializeField]
    protected Vector2 moveDirection;


    public float speed;

    public int scoreValue;

    public enum ballAlignment
    {
        Player,
        Opponent
    }

    public ballAlignment alignmentType;

    public void SetDirection(Vector2 newDirection)
    {
        moveDirection = newDirection;
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    private void Update()
    {
        Move();

        if (transform.position.y >= 8f)
        {
            GameManager.instance.IncrementScore(scoreValue);
            Destroy(gameObject);
        }
        else if (transform.position.y <= -6f)
        {
            GameManager.instance.DecrementScore(scoreValue);
            Destroy(gameObject);
        }
    }

    public virtual void Move()
    {
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }

    public virtual void Ability(){}

    public virtual void OnCollisionEnter2D(Collision2D other) 
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
            SetDirection(new Vector2(moveDirection.x, moveDirection.y * -1f));
        }
    }

}
