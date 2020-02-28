using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

     private void Start() 
    {

    }

    public int timeRemaining;

    public int doorsRemaining;

    public void doorEntered()
    {
        doorsRemaining--;

        if (doorsRemaining <= 0)
        {
            EndGame();
        }

        SpawnManager.instance.ClearAll();
        SpawnManager.instance.Populate();
    }

    public void PlayerFailedToEnterDoor()
    {
        doorsRemaining++;

        SpawnManager.instance.ClearAll();
        SpawnManager.instance.Populate();
    }

    public void EndGame()
    {

    }
}
