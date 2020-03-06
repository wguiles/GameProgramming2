using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpAndDown : MonoBehaviour, ISavableObject
{
    public float speed;
    public float direction = 1f;

    public float yLimitTop;

    public float yLimitBottom;

    public void Move()
    {
        transform.Translate(new Vector2(speed * Time.deltaTime * direction, 0f));

        if (transform.position.x > yLimitTop)
        {
            transform.position = new Vector2(yLimitTop, transform.position.y);
            ChangeDirection();
        }
        else if (transform.position.x < yLimitBottom)
        {
            transform.position = new Vector2(yLimitBottom, transform.position.y);
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
