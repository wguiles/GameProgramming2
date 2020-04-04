using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUnderlingsState : MonoBehaviour, EnemyState
{

     /*
		 * Warren Guiles
		 * PatrolState
		 * Assignment 9
		 * This is one of the concrete states for the state machine.
         This specific state involves stopping and spawning more 
         enemies called "underlings".
	*/

    public GameObject underling;

    public float underlingSpawnRate = 10f;
    private float currentTimer = 0f;

    public void Move(GameObject enemyToMove)
    {
        return; //enemy does not move
    }

    public void Action(GameObject enemy)
    {
        currentTimer += Time.deltaTime * underlingSpawnRate;
        
        if (currentTimer >= 1.0f)
        {
            currentTimer = 0f;
            SpawnUnderling(enemy);
        }
    }

    private void SpawnUnderling(GameObject spawnOrigin)
    {
        if (underling == null)
        {
             underling = Resources.Load<GameObject>("Underling");
        }

        Instantiate(underling, spawnOrigin.transform.position + RandomOffSet(), Quaternion.identity);
    }

    private Vector3 RandomOffSet()
    {
        Vector3 newOffset = new Vector3(Random.Range(1.5f, 4f), Random.Range(1.5f, 4f), Random.Range(1.5f, 4f));

        newOffset *= Random.Range(-1.0f, 1.0f);

        return newOffset;
    }



}
