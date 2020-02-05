using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;

    private int direction = 1;

    // Update is called once per frame
    void Update()
    {
        Move();

    }

    public void Move()
    {
        transform.Translate(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed * Time.deltaTime);
    }

    public void Shooting()
    {
        
    }
}
