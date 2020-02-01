using System.Collections;
using System.Collections.Generic;
using UnityEngine;


		/*
		 * Warren Guiles
		 * Enemy.cs
		 * Assignment 2
		 * 
		 */

public class Enemy : MonoBehaviour
{

    public enum enemyType
    {
        verticon,

        horizon,
    }

    public enemyType type;

    public IMoveBehaviour moveBehaviour;

    public int speed;

    private void Awake() 
    {
        if (type == enemyType.verticon)
        {
            moveBehaviour = new MoveVertically();
        }
        else
        {
            moveBehaviour = new MoveHorizontally();
        }
    }

    public void Move()
    {
        //call movement method of movebehaviour
        moveBehaviour.Movement(speed, gameObject);
    }

     private void Update() 
     {
         Move();
    }

    private void Death()
    {
        //die and get removed from the game (destroy this gameObject)
    }

    public void SwapBehaviour()
    {
        if (moveBehaviour is MoveHorizontally || moveBehaviour is MoveVertically)
        {
            SetMoveBehaviour(new MoveTowards());
        }
        else
        {
            if (type == enemyType.horizon)
            {
                SetMoveBehaviour(new MoveHorizontally());
            }
            else
            {
                SetMoveBehaviour(new MoveVertically());
            }
        }
    }


    public void SetMoveBehaviour(IMoveBehaviour newBehaviour)
    {
        //My old man's drunker than a barrel full of monkeys and 
        //my old lady she don't care
        moveBehaviour = newBehaviour;
    }

      private void OnCollisionEnter2D(Collision2D other) 
      {
         Debug.Log("Hit collision");

         Enemy enemyHit = other.gameObject.GetComponent<Enemy>();

         if (enemyHit != null && other.gameObject.GetComponent<Enemy>().type != type)
         {
             if (type == enemyType.horizon)
             {
                 EnemyManager.instance.Switch();
             }

             Destroy(other.gameObject);
             Destroy(this.gameObject);

             EnemyManager.instance.CheckForWin();
         }
         else if (other.gameObject.tag == "Player")
         {
             uiManager.instance.DisplayDefeatPanel();
             Destroy(other.gameObject);
         }
     }


}
