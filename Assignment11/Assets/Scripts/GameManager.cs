using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 /*
	 * Warren Guiles
	 * GameManager.cs
	 * Assignment 11
	 * This is the high level facade interface. The gameManager has methods that communicate with
     the soundManager, spawnmanager, and UImanager.
 */
public class GameManager : MonoBehaviour
{
    public SoundManager soundManager;
    public EnemySpawner spawnManager;

    public UIManager uIManager;

    public void SendSwarm()
    {
        spawnManager.SpawnSwarm();
        soundManager.SwarmSound();
    }

    public void Win()
    {
        uIManager.DisplayWinScreen();
        soundManager.PlayWinSound();
    }

    public void Lose()
    {
        uIManager.DisplayLoseScreen();
        soundManager.LoseSound();
    }

    public void FeedbackUpdate()
    {
        uIManager.UpdateHealthBar();
    }
}
