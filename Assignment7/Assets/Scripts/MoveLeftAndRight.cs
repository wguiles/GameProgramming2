using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
    * Warren Guiles
    * MoveLeftAndRight.cs
    * Assignment7
    * This is a script I use for basic enemy behaviour. It allows
    the enemies in the game to move left and right.
*/

public class MoveLeftAndRight : MonoBehaviour, ISavableObject
{
    public float speed;
    public float direction = 1f;

    public float xLeftLimit;

    public float xRightLimit;

    public void Move()
    {
        transform.Translate(new Vector2(speed * Time.deltaTime * direction, 0f));

        if (transform.position.x > xRightLimit)
        {
            transform.position = new Vector2(xRightLimit, transform.position.y);
            ChangeDirection();
        }
        else if (transform.position.x < xLeftLimit)
        {
            transform.position = new Vector2(xLeftLimit, transform.position.y);
            ChangeDirection();            
        }
    }

    private void Update() 
    {
        Move();
    }

    public void ChangeDirection()
    {
        direction *= -1f;
    }

    public Transform GetTransform()
    {
        return transform;
    }

    public GameObject GetObject()
    {
        return gameObject;
    }

    public Color GetSpriteColor()
    {
        return gameObject.GetComponent<SpriteRenderer>().color;
    }

    public int GetLayer()
    {
        return gameObject.layer;
    }


}
