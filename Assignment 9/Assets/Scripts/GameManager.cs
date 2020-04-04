using System.Collections;
using System.Collections.Generic;
using UnityEngine;


	/*
		 * Warren Guiles
		 * GameManager
		 * Assignment 9
		 * This is a manger that keeps track of the 
         number of enemies left in the level in order
         to implement the win state.
	*/
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake() 
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public float enemiesLeft;

    public void EnemyDefeated()
    {
        enemiesLeft--;

        if (enemiesLeft <= 0)
        {
            PlayerWins();
        }
    }

    public void PlayerWins()
    {
        UIManager.instance.DisplayWinPanel();
    }
}
