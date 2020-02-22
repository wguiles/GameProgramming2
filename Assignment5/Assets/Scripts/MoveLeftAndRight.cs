using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Warren Guiles
 * MoveLeftAndRight.cs
 * Assignment 5
 * This script is for the opponent paddles in the level.
 It allows the paddles to move left and right and controls
 there speed.
 */

public class MoveLeftAndRight : MonoBehaviour
{
    public float xLimitLeft;

    public float xLimitRight;

    public float MoveSpeed;

    private float direction = 1f;

    void Update()
    {
        transform.Translate(new Vector2(1f, 0f) * MoveSpeed * Time.deltaTime * direction);

        if (transform.position.x > xLimitRight)
        {
            transform.position = new Vector2(xLimitRight, transform.position.y);
            direction *= -1f;
        }
        else if (transform.position.x < xLimitLeft)
        {
            transform.position = new Vector2(xLimitLeft, transform.position.y);
            direction *= -1f;
        }
    }

    public void Stun()
    {
        StartCoroutine(GetStunned());
    }

    IEnumerator GetStunned()
    {
        int tempDirection = (int)direction;
        direction = 0;

        yield return new WaitForSeconds(2.0f);

        direction = tempDirection;
    }
    
}
