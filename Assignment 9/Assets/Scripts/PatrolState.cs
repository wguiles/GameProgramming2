using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : MonoBehaviour, EnemyState
{
    /*
		 * Warren Guiles
		 * PatrolState
		 * Assignment 9
		 * This is one of the concrete states for the state machine.
         This specific state involves bobbing up and down.
	*/
    private float patrolSpeed = 10f;

    private Vector3 basePosition;

    private Vector3 offset = new Vector3(0f, 5f, 0f);
    
    private bool goingToStart = false;

    public void Move(GameObject enemyToMove)
    {
       if (basePosition == Vector3.zero)
       {
           Debug.Log("Base position has been set");
           basePosition = enemyToMove.transform.position;
       }


          if (!goingToStart)
          {
              enemyToMove.transform.position = Vector3.MoveTowards(enemyToMove.transform.position, basePosition - offset, patrolSpeed * Time.deltaTime);

              if (Vector3.Distance(enemyToMove.transform.position, basePosition - offset) <= 0.5f)
              {
                  goingToStart = true;
              }
          }
          else if (goingToStart)
          {
              enemyToMove.transform.position = Vector3.MoveTowards(enemyToMove.transform.position, basePosition + offset, patrolSpeed * Time.deltaTime);

                if (Vector3.Distance(enemyToMove.transform.position, basePosition + offset) <= 0.5f)
              {
                  goingToStart = false;
              }
          }
    }

    public void Action(GameObject enemy)
    {
        Debug.Log("Do nothing while bobbing up and down");
        //maybe generate a new random direction here or something
    }

}
