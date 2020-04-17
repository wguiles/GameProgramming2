using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugEnemy : MonoBehaviour
{

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
