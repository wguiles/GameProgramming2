using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject[] enemySpawns;

    public GameObject[] doorSpawns;

    private void Awake() 
    {
        if (instance == null)
        {
            instance = this;
        }
    }

     private void Start() 
    {
        enemySpawns = GameObject.FindGameObjectsWithTag("EnemySpawn");
        doorSpawns  = GameObject.FindGameObjectsWithTag("Door");
    }

    public void Populate()
    {
        //spawn a few random enemies
        int enemiesSpawned = 0;

        
    }


    public int timeRemaining;

    public int doorsRemaining;

    public void doorEntered()
    {
        doorsRemaining--;
    }

    public void EndGame()
    {

    }
}
