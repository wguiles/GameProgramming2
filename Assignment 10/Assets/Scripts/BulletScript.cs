using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bulletSpeed;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void SetVelocity(Vector2 newVelocity)
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
        }

        rb.velocity = newVelocity * bulletSpeed;
    }
}
