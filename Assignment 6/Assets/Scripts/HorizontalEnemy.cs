using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalEnemy : GameCharacter
{
    public float speed;
    private float direction = 1f;

    public float xLeftLimit;

    public float xRightLimit;

    public override void SetPosition(Vector2 newPos)
    {
        transform.position = newPos;

        xLeftLimit = newPos.x - 3;

        xRightLimit = newPos.x + 3;


    }

    public override void Die()
    {
        Destroy(gameObject);
    }

    public override void Move()
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
