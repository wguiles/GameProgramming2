using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


/*
     * Warren Guiles
	 * GameManager.cs
	 * Assignment 4
	 * This is the main driver script that executes the fight,
    displays stats, allows character creation, and displays 
    all UI in the game
*/

public class GameManager : MonoBehaviour
{
    //UI ELEMENTS
    public TextMeshProUGUI enemyDescriptionText;
    public TextMeshProUGUI enemyIntelligenceText;
    public TextMeshProUGUI enemyToughnessText;
    public TextMeshProUGUI enemySpeedText;

    public TextMeshProUGUI playerDescriptionText;
    public TextMeshProUGUI playerIntelligenceText;
    public TextMeshProUGUI playerToughnessText;

    public TextMeshProUGUI playerSpeedText;

    public TextMeshProUGUI fightText;

    public Image playerHealthBar;

    public Image enemyHealthBar;

    public GameObject victoryPanel;

    public GameObject defeatPanel;

    public void UpdatePlayerText()
    {
        playerDescriptionText.text = playerFighter.GetDescription().ToString();

        playerIntelligenceText.text = playerFighter.GetIntelligence().ToString();

        playerToughnessText.text = playerFighter.GetToughness().ToString();

        playerSpeedText.text = playerFighter.GetSpeed().ToString();
    }

    public void UpdateEnemyText()
    {
        enemyDescriptionText.text = currentOpponent.GetDescription().ToString();

        enemyIntelligenceText.text = currentOpponent.GetIntelligence().ToString();

        enemyToughnessText.text = currentOpponent.GetToughness().ToString();

        enemySpeedText.text = currentOpponent.GetSpeed().ToString();
    }

    public void updateFightText(string newText)
    {
        fightText.text = newText;
    }

    public void UpdateFightHealth()
    {
        playerHealthBar.fillAmount = (float)playerFighter.health / 100;
        enemyHealthBar.fillAmount = (float)currentOpponent.health / 100;
    }






    //ENEMY STUFF
    private RobotFighter currentOpponent;

    private void Start() 
    {
        currentOpponent = randomEnemy();
        UpdateEnemyText();

    }

    public RobotFighter randomEnemy()
    {
        RobotFighter newOpponent = null;

        //Randomly decide which build the enemy will have

        int randomNum = Random.Range(0,3);

        if (randomNum == 2)
        {
            newOpponent = new LilDipper();
        }
        else if (randomNum == 1)
        {
            newOpponent = new NoisyBoy();
        }
        else
        {
            newOpponent = new Zeus();
        }

        for (int i = 0; i < 2; i ++)
        {
        int secondRandomNum = Random.Range(0,3);

         if (secondRandomNum == 0)
        {
            newOpponent = new TwinIonEngine(newOpponent);
        }
        else if (secondRandomNum == 1)
        {
            newOpponent = new VulcanBrain(newOpponent);
        }
        else
        {
            newOpponent = new HydraulicFists(newOpponent);
        }

       
        
        }

    return newOpponent;
        //Randomly decide which two upgrades it will have.
    }

    //PLAYER STUFF

    private RobotFighter playerFighter;


    public void SetPlayerBuild(int newBuild)
    {
        if (newBuild == 0)
        {
            playerFighter = new LilDipper();
        }
        else if (newBuild == 1)
        {
            playerFighter = new NoisyBoy();
        }
        else
        {
            playerFighter = new Zeus();
        }

        UpdatePlayerText();
    }

    public void AddPlayerUpgrade(int upgrade)
    {
        if (upgrade == 0)
        {
            playerFighter = new HydraulicFists(playerFighter);
        }
        else if (upgrade == 1)
        {
            playerFighter = new VulcanBrain(playerFighter);
        }
        else
        {
            playerFighter = new TwinIonEngine(playerFighter);
        }

        UpdatePlayerText();
    }

    private bool fightStarted = false;

    public void Fight()
    {

        if (playerFighter.health <= 0 || currentOpponent.health <=0)
        {
            return;
        }

            string currentMove = "";
            //generate which stat we're competing with

            int currentStatChallenge = Random.Range(0,3);

            if (currentStatChallenge == 0)
            {
                //a battle of fists
                if (playerFighter.GetToughness() == currentOpponent.GetToughness())
                {
                    currentMove = "Player's " + playerFighter.GetName() + " does a full on collision with opponent's " + currentOpponent.GetName()
                    + ". Both Take some hits!";

                    playerFighter.health -= 60;
                    currentOpponent.health -= 60;
                }
                else if (playerFighter.GetToughness() > currentOpponent.GetToughness())
                {
                    currentMove = "Player's " + playerFighter.GetName() + " absolutely clobbers opponent's " + currentOpponent.GetName();
                    currentOpponent.health -= 20;
                }
                else
                {
                    currentMove = "Opponent's " + currentOpponent.GetName() + " absolutely clobbers player's " + playerFighter.GetName();
                    playerFighter.health -= 20;
                }
            }
            else if (currentStatChallenge == 1)
            {
                //a battle of wits
                if (playerFighter.GetIntelligence() == currentOpponent.GetIntelligence())
                {
                    currentMove = "It seems that the CPUs of both robots are fried! They're going haywire!" ;

                    playerFighter.health -= 30;
                    currentOpponent.health -= 30;
                }
                else if (playerFighter.GetIntelligence() > currentOpponent.GetIntelligence())
                {
                    currentMove = "Player's " + playerFighter.GetName() + " temporarily hacks into opponent's " + currentOpponent.GetName();
                    currentOpponent.health -= 10;
                }
                else
                {
                    currentMove = "Opponent's " + currentOpponent.GetName() + " temporarily hacks into player's " + playerFighter.GetName();
                    playerFighter.health -= 10;
                }
            }
            else
            {
                //a battle of speed
                if (playerFighter.GetSpeed() == currentOpponent.GetSpeed())
                {
                    currentMove = "Both bots are zooming into each other at the speed of light!" ;

                }
                else if (playerFighter.GetSpeed() > currentOpponent.GetSpeed())
                {
                    currentMove = "Player's " + playerFighter.GetName() + " quickly spins around to confuse opponent's " + currentOpponent.GetName();
                    currentOpponent.health -= 16;
                }
                else
                {
                    currentMove = "Opponent's " + currentOpponent.GetName() + " quickly spins around to confuse player's " + playerFighter.GetName();
                    playerFighter.health -= 16;
                }
            }

            
            if (!fightStarted)
            {
                currentMove = "Fight Begins! " + currentMove;
                fightStarted = true;
            }

            if (playerFighter.health <= 0)
            {
                currentMove += ". Player's " + playerFighter.GetName() + " goes down!";
                StartCoroutine(displayDefeat());
            }

            if (currentOpponent.health <= 0)
            {
                currentMove += ". Opponent's " + currentOpponent.GetName() + " goes down!";
                StartCoroutine(displayVictory());
            }

            updateFightText(currentMove);
            UpdateFightHealth();
    }

    private IEnumerator displayVictory()
    {
        yield return new WaitForSeconds(4.0f);
        victoryPanel.SetActive(true);
    }

    private IEnumerator displayDefeat()
    {
        yield return new WaitForSeconds(4.0f);
        defeatPanel.SetActive(true);
    }

}
