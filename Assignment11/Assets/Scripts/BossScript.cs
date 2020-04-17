using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
	 * Warren Guiles
	 * BossScript.cs
	 * Assignment 11
	 * This is the script that handles the boss of the game. It is also one of the clients
     that communicates with the facade in the facade pattern. It handles movement, collision,
     and communicating with the manager script
 */
public class BossScript : MonoBehaviour
{
    public float health;
    public float bossSpeed;

    private float direction = 1f;

    public GameManager manager;

    private void Start() 
    {
        StartCoroutine(spawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    
    public void Move()
    {
        transform.Translate(new Vector2(bossSpeed * direction, 0f) * Time.deltaTime);

        if (direction > 0 && transform.position.x > 7.3f)
        {
            transform.position = new Vector3 (7.3f, transform.position.y);
            ChangeDirection();
        }
        else if (direction < 0 && transform.position.x < -7.3f)
        {
            transform.position = new Vector3 (-7.3f, transform.position.y);
            ChangeDirection();
        }
    }

    IEnumerator spawnEnemies()
    {
        while(true)
        {
            yield return new WaitForSeconds(3f);
            manager.SendSwarm();
        }
    }

    IEnumerator damageIndication()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        yield return new WaitForSeconds(0.05f);
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    private void ChangeDirection()
    {
        direction *= -1f;
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(other.gameObject);
            health--;
            StartCoroutine(damageIndication());
            manager.FeedbackUpdate();

            if (health <= 0f)
            {
                manager.Win();
            }
        }
    }

    public int GetHealth()
    {
        return (int)health;
    }




}
