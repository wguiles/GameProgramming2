using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractEnemy : MonoBehaviour
{

    protected Transform player;
    public float enemySpeed;

    public void Attack()
    {
        MoveTowardsPlayer();
        Shoot();
        Jump();
    }

    public void MoveTowardsPlayer()
    {
        if (player.position.x < transform.position.x)
        {
            transform.Translate(new Vector2(-1 * enemySpeed * Time.deltaTime, 0f));
        }
        else
        {
            transform.Translate(new Vector2(1 * enemySpeed * Time.deltaTime, 0f));
        }
    }

    public abstract void Shoot();

    public abstract void Jump();

    private void Update() 
    {
        Attack();    
    }


}
