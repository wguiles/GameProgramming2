using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

/*
 * Warren Guiles
 * GameManager.cs
 * Assignment 5
 * This is the main script that handles the mechanics of the game.
    It keeps track of score and time remaining, and displays all
    information to the in game UI
 */


public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI abilityText;

    public TextMeshProUGUI timeLeftText;

    public Image endPanelImage;

    public TextMeshProUGUI StatusText;

    public GameObject EndGameButton;

    public static GameManager instance;

    private bool gameEnded = false;


    private void Awake() 
    {
        if (instance == null)
            instance = this;
    }

    public int ScoreRequirement = 1;

    public float timeRemaining;

    private int currentScore = 0;

    public void IncrementScore(int amountToIncrementBy)
    {
        if (gameEnded)
            return;

        currentScore += amountToIncrementBy;
        UpdateScoreText();
    }

    public void DecrementScore(int amountToDecrementBy)
    {
        if (gameEnded)
            return;

        currentScore -= amountToDecrementBy;
        UpdateScoreText();
    }

    private void Update() 
    {
        timeRemaining -= Time.deltaTime;
        timeLeftText.text = ((int)timeRemaining).ToString();

        if (timeRemaining <= 0 && !gameEnded)
        {
            gameEnded = true;
            EndGame();
        }
    }

    public void EndGame()
    {
        endPanelImage.enabled = true;
        StatusText.enabled = true;
        EndGameButton.SetActive(true);
        timeLeftText.enabled = false;

        if (currentScore >= ScoreRequirement)
        {
            StatusText.text = "You Win! Score Goal Reached!";
        }
        else
        {
            StatusText.text = "You Lose! Score Goal Not Reached!";
        }
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + currentScore.ToString() + "/" + ScoreRequirement.ToString();
    }

    public void UpdateAbilityText(int currentAbility)
    {   
        if (currentAbility == 0)
        {
            abilityText.text = "Ability: Normal";
        }
        else if (currentAbility == 1)
        {
            abilityText.text = "Ability: Sneak and Speed";
        }
        else if (currentAbility == 2)
        {
            abilityText.text = "Ability: SlowStun";
        }
    }

    
}
