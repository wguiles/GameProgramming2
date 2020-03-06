using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour, ISavableObject
{
    private Rigidbody2D rb;
    public float jumpHeight;
    public float moveSpeed;

    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2.0f;

    private Vector2 startingPosition;

    private void Start() 
    {
        Physics.IgnoreLayerCollision(8, 9);
        rb = GetComponent<Rigidbody2D>();
        startingPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            CommandManager.instance.UndoCommand("PlayerBackground");
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            Jump();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
             CommandManager.instance.ExecuteCommand("PlayerBackground");
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            CommandManager.instance.ExecuteCommand("SaveStateDriver");
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            CommandManager.instance.UndoCommand("SaveStateDriver");
        }

        transform.Translate(new Vector2(moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0f));
    }
    private void FixedUpdate() 
    {
        
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }


    public void Jump()
    {
        rb.AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
    }
    
    public GameObject GetObject()
    {
        return gameObject;
    }

    public Transform GetTransform()
    {
        return transform;
    }

    public int GetLayer()
    {
        return gameObject.layer;
    }

    public Color GetSpriteColor()
    {
        return GetComponent<SpriteRenderer>().color;
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "Enemy")
        {
            ResetPlayerPosition();
        }
    }

    private void ResetPlayerPosition()
    {
        transform.position = startingPosition;
    }
}
