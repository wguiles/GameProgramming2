using System.Collections;
using System.Collections.Generic;
using UnityEngine;


   /*
	* Warren Guiles
	 * PlayerMovement
	 * Assignment 10
	 * This script handles player movement, shooting, and collsiion.
 */


public class PlayerMovement : MonoBehaviour
{
   public float moveSpeed;
   public Camera cam;

   public Rigidbody2D rigidBody;

    public Transform muzzle;


    Vector2 mousePos;

    public float suckInMoneySpeed;
    public float suckInMoneyDistance;


    // Update is called once per frame
    void Update()
    {
       mousePos = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
       Debug.Log(mousePos.x);

       if (Input.GetMouseButtonDown(0))
       {
           Shoot();
       }

       CheckForConstraints();

       SuckInMoney();
    }

     public void Shoot()
    {
        GameObject newBullet = ObjectPooler.instance.SpawnFromPool("Bullet", muzzle.transform.position, Quaternion.identity);

        Vector2 lookDir = mousePos - rigidBody.position;

        newBullet.GetComponent<BulletScript>().SetVelocity(lookDir);

        PushPlayerBack(-lookDir);
    }

    public void CheckForConstraints()
    {
        if (transform.position.y > 7.0f && rigidBody.velocity.y > 0f)
        {
            transform.position = new Vector2(transform.position.x, -7.00f);
        }
        else if (transform.position.y < -7.0f && rigidBody.velocity.y < 0f)
        {
            transform.position = new Vector2(transform.position.x, 7.0f);
        }
        else if (transform.position.x > 11.5f && rigidBody.velocity.x > 0f)
        {
            transform.position = new Vector2(-11.5f, transform.position.y);
        }
        else if (transform.position.x < -11.5f && rigidBody.velocity.x < 0f)
        {
            transform.position = new Vector2(11.5f, transform.position.y);
        }
    }

    public void PushPlayerBack(Vector2 newPush)
    {
        rigidBody.velocity = Vector2.zero;
        rigidBody.AddForce(newPush, ForceMode2D.Impulse);
    }

    private void FixedUpdate() 
    {
        Vector2 lookDir = mousePos - rigidBody.position;

        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rigidBody.rotation = angle;
    }

    public void SuckInMoney()
    {
        //reference for all money objects in scene
        GameObject[] moneyObjs = GameObject.FindGameObjectsWithTag("Money");

        foreach (GameObject g in moneyObjs)
        {
            if (Vector2.Distance(g.transform.position, transform.position) <= suckInMoneyDistance)
            {
                g.transform.position = Vector3.MoveTowards(g.transform.position, transform.position, Time.deltaTime * suckInMoneySpeed);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Money")
        {
            other.gameObject.SetActive(false);

            if (GameManager.instance == null)
            {
                return;
            }

            GameManager.instance.collectMoney();
            
        }
        else if(other.gameObject.tag == "Enemy")
        {
            if (GameManager.instance == null)
            {
                return;
            }
            GameManager.instance.DisplayLossPanel();
            gameObject.SetActive(false);
        }
    }
}
