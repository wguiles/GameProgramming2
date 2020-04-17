using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float playerSpeed;
    public GameObject bullet;

    public GameManager manager;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.Translate(new Vector2(playerSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0f));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Enemy")
        {
            manager.Lose();
        }
    }
}
