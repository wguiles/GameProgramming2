using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

       /*
     * Warren Guiles
    * PlayerController.cs
    * Assignment 5
    * This script handles the player's movement and firing. It also 
    references the creator in order to spawn the balls that it fires.
    It has methods for movement, switching balls, and firing.
    */

    private BallCreator creator;

    public float fireRate;
    private float currentTimer = 0f;

    public float timeSpentFrozen;

    private bool isFrozen;

    public enum balls
    {
        Normal,

        SneakAndSpeed,

        SlowStun
    }

    public balls ballType;

    private void Awake() 
    {
        creator = FindObjectOfType<BallCreator>();
    }

    public float moveSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        if (!isFrozen)
        {
            transform.Translate(new Vector2(Input.GetAxis("Horizontal"), 0f) * moveSpeed * Time.deltaTime);
        }

        currentTimer += Time.deltaTime;

        if (isFrozen && currentTimer >= timeSpentFrozen)
        {
            isFrozen = false;
        }

        if (currentTimer >= fireRate && !isFrozen)
        {
            if (Input.GetAxisRaw("FireAxisY") != 0 || Input.GetAxisRaw("FireAxisX") != 0)
             {

                 currentTimer = 0f;

                 Vector2 ballDirection = new Vector2(Input.GetAxisRaw("FireAxisX"), 1);
            
                creator.SpawnBall(ballType.ToString(), transform.GetChild(0).transform.position + new Vector3(0f, 0.5f), ballDirection);
             }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("SwitchedBulletType");

            SwitchBulletType();
        }
    }

    public void FreezePlayer()
    {
        isFrozen = true;
        currentTimer = 0f;
    }

    public void SwitchBulletType()
    {
        int currentBullet = (int)ballType;

        currentBullet++;

        if (currentBullet > 2)
        {
            currentBullet = 0;
        }

        GameManager.instance.UpdateAbilityText(currentBullet);

        ballType = (balls)currentBullet;
    }
}
