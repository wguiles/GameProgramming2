using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour, IBossNode
{
    public float moveSpeed;

    public float xLimitLeft;
    public float xLimitRight;

    private float direction = 1f;

    
    void Update()
    {
        transform.Translate(new Vector2(1f, 0) * moveSpeed * Time.deltaTime * direction);

        if (direction == 1 && transform.position.x >= xLimitRight) 
        {
            ChangeDirection();
            transform.position = new Vector3(xLimitRight, transform.position.y);
        }
        else if (direction == -1 && transform.position.x <= xLimitLeft)
        {
            ChangeDirection();
            transform.position = new Vector3(xLimitLeft, transform.position.y);
        }
    }

    public GameObject GetGameObject()
    {
        return gameObject;
    }

    public void updateBehaviour(int healthRemaining)
    {
        //change movement of the main node based off of movement
    }

    private void ChangeDirection()
    {
        direction *= -1f;
    }
}
