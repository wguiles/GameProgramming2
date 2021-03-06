﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastPlayer : GameCharacter
{

     /*
	 * Warren Guiles
	 * FastPlayer.cs
	 * Assignment 6 
	 * This is a variation of the player that gets spawned 
     by the factory. This version is faster than the normal player
*/

    public float speed;
    public float JumpHeight;

    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;

    public override void Move()
    {
        Vector2 horizontalMovement = new Vector2(Input.GetAxis("Horizontal"), 0f);
        transform.Translate(horizontalMovement * speed * Time.deltaTime);
    }

    private void Update() 
    {
        Move();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }


        if (transform.position.y <= -7f)
        {
            GameManager.instance.PlayerFailedToEnterDoor();
        }
    }

    private void FixedUpdate() 
    {
        Rigidbody2D playerRigidBody = GetComponent<Rigidbody2D>();

        if (playerRigidBody.velocity.y < 0)
        {
            playerRigidBody.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (playerRigidBody.velocity.y > 0 && !Input.GetKey(KeyCode.Space))
        {
            playerRigidBody.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }

    public void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,JumpHeight), ForceMode2D.Impulse);
    }

    public void EnterDoor()
    {
        //update game score or something

        GameManager.instance.doorEntered();
        //kill this player... sorry bud
        Die();
    }

    public override void Die()
    {
        Destroy(gameObject);
    }

    public override void SetPosition(Vector2 newPos)
    {
        transform.position = newPos;
    }

    public override void ActivateAbility()
    {
        speed = 10f;
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "Enemy")
        {
            GameManager.instance.PlayerFailedToEnterDoor();
            Die();
        }    
    }

    private void OnTriggerStay2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Door" && Input.GetKeyDown(KeyCode.W))
        {
            Door doorEntered = other.gameObject.GetComponent<Door>();

            SpawnManager.instance.SetType(doorEntered.type);

            EnterDoor();
        }
    }
}
