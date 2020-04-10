using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
	* Warren Guiles
	 * EnemyScript
	 * Assignment 10
	 * This is a basic script that has a method for setting it's velocity
     and moving it based on a set speed. It also handles collision
     for death and spawning money.
 */

public class EnemyScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SetRandomVelocity();
    }

    public void SetRandomVelocity()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
        }
        rb.velocity = Vector2.zero;
        //find a position towards the center of the screen, plus an offset
        Vector2 offSet = new Vector2(Random.Range(-8f, 8f), Random.Range(-3f, 5f));

        //rb.velocity = Vector2.zero;

        Vector2 newDirection = offSet - (Vector2)transform.position;
        newDirection.Normalize();
        rb.velocity = newDirection;
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Bullet")
        {
            Death();
            other.gameObject.SetActive(false);
        }
    }

    public void Death()
    {
        //Spawn a fuck ton of money
        for(int i = 0; i < 40; i ++)
        {
            GameObject newMoney = ObjectPooler.instance.SpawnFromPool("Money", transform.position + new Vector3(Random.Range(0f, 3f), Random.Range(0f, 3f))
            , Quaternion.identity);
        }

        gameObject.SetActive(false);
    }
}
