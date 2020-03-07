using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
    * Warren Guiles
    * PlayerBehaviour.cs
    * Assignment7
    * This is a script that controls the player's jump, while also
    accessing commands for switching colors and saving 
    and loading save states
*/
public class PlayerBehaviour : MonoBehaviour, ISavableObject
{
    private Rigidbody2D rb;
    public float jumpHeight;
    public float moveSpeed;

    public GameObject loseScreen;

    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2.0f;

    private bool canJump = false;

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
        if (Input.GetKeyDown(KeyCode.K))
        {
            CommandManager.instance.UndoCommand("PlayerBackground");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canJump)
            {
                Jump();
            }
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
             CommandManager.instance.ExecuteCommand("PlayerBackground");
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            CommandManager.instance.ExecuteCommand("SaveStateDriver");
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            CommandManager.instance.UndoCommand("SaveStateDriver");
        }

        transform.Translate(new Vector2(moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0f));

        if (transform.position.y <= -85.0f)
        {
            LoseGame();
        }
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
        canJump = false;
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
            LoseGame();
        }
        else if (other.gameObject.tag == "Floor")
        {
            canJump = true;
        }
    }

    private void ResetPlayerPosition()
    {
        transform.position = startingPosition;
    }

    public void LoseGame()
    {
        loseScreen.SetActive(true);
    }
}
