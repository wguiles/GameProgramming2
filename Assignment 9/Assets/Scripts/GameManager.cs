using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameManager instance;

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
