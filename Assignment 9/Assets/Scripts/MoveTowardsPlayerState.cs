using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsPlayerState : MonoBehaviour, EnemyState
{
    public Transform player;

    public float pursuitSpeed = 20f;

    private void Start() 
    {
        
    }


    public void Move(GameObject enemy)
    {   
        if (player == null)
        {
            player = GameObject.FindWithTag("Player").transform;
        }

        enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, player.position, pursuitSpeed * Time.deltaTime);
    }

    public void Action(GameObject enemy)
    {
        Debug.Log("Doing nothing while moving");
    }

    public void SetSpeed(float newSpeed)
    {
        pursuitSpeed = newSpeed;
    }
}
