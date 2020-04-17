using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
	 * Warren Guiles
	 * AbstractEnemy.cs
	 * Assignment 8
	* This script is the base for the enemy template. The attack 
    method is the method with all of the methods inside it that are overriden.
 */
public abstract class AbstractEnemy : MonoBehaviour
{

    protected Transform player;
    public float enemySpeed;

    private void Start() 
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

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
