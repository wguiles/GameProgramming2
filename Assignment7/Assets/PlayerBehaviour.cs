using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpHeight;
    public float moveSpeed;

    private void Start() 
    {
        Physics.IgnoreLayerCollision(8, 9);
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SwitchCollsionLayer();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            Jump();
        }

        transform.Translate(new Vector2(moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0f));
    }

    public void SwitchCollsionLayer()
    {
        if (gameObject.layer == 8)
        {
            GetComponent<SpriteRenderer>().color = Color.blue;
            gameObject.layer = 9;
        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.yellow;
            gameObject.layer = 8;
        }
    }

    public void Jump()
    {
        rb.AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
    }

}
