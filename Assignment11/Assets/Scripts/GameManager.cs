using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
