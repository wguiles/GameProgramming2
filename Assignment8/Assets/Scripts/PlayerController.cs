using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed;
    public float jumpHeight;

    public GameObject playerBullet;

    private Rigidbody2D rb;

    private void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move()
    {
        transform.Translate(new Vector2(Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime, 0f));
    }

    public void Jump()
    {
        rb.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        if (Input.GetAxisRaw("FireAxis") != 0)
        {
            GameObject newBullet = Instantiate(playerBullet, transform.position, Quaternion.identity);
            Bullet newBulletScript = newBullet.GetComponent<Bullet>();
            newBulletScript.SetDirection((int)Input.GetAxisRaw("FireAxis"));
        }
    }
}
