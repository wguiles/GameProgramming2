using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugEnemy : MonoBehaviour
{

 /*
	 * Warren Guiles
	 * BugEnemy.cs
	 * Assignment 11
	 * This is the script that handles the bug enemy that the boss spawns. it has implementations
     for ssetting the enemy's destination and speed. It also handles collision
 */

    private float speed = 0.005f;

    private Transform player;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    public void SetDestination()
    {
        direction = player.position - transform.position;
    }

    public void SetRandomSpeed()
    {
        speed = Random.Range(1f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

        }
    }

    
}
