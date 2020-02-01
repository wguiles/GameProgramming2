using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyManager : MonoBehaviour
{

    		/*
		 * Warren Guiles
		 * EnemyManager.cs
		 * Assignment 2
		 * This controls the enemies within the game, including how they
            switch between patrolling and pusuing. It also contains
            a list of all enemies for win state.
		 */

    public static EnemyManager instance;



    private GameObject[] enemies;

     private void Awake() 
     {

        if (instance == null)
        {
            instance = this;
        }

        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach(GameObject enem in enemies)
        {
            if (enem.GetComponent<Enemy>().type == Enemy.enemyType.verticon)
            {
                enem.GetComponent<Enemy>().SetMoveBehaviour(new MoveVertically());
            }
            else
            {
                enem.GetComponent<Enemy>().SetMoveBehaviour(new MoveHorizontally());
            }
        }

        int randomNum = Random.Range(0,2);

        if (randomNum == 1)
        {
            foreach(GameObject enem in enemies)
            {
                if (enem.GetComponent<Enemy>().moveBehaviour is MoveVertically)
                {
                    enem.GetComponent<Enemy>().SwapBehaviour();
                }
            }
        }
        else
        {

            foreach(GameObject enem in enemies)
            {
                if (enem.GetComponent<Enemy>().moveBehaviour is MoveHorizontally)
                {
                    enem.GetComponent<Enemy>().SwapBehaviour();
                }
            }
        }

     }

     public void Switch()
     {
         enemies = GameObject.FindGameObjectsWithTag("Enemy");

         if (enemies.Length == 0)
         {
             Debug.Log("Player wins!");
         }

        foreach(GameObject enem in enemies)
        {
            enem.GetComponent<Enemy>().SwapBehaviour();
        }
     }

     public void CheckForWin()
     {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

         if (enemies.Length == 0)
         {

             uiManager.instance.DisplayVictoryPanel();
         }

     }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

         if (enemies.Length == 0)
         {
             Debug.Log("Player wins!");
              uiManager.instance.DisplayVictoryPanel();
         }
    }
}
