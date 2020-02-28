using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public TextMeshProUGUI timeRemainingText;
    public TextMeshProUGUI doorsRemainingText;

    public GameObject winPanel;
    public GameObject losePanel;

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

    public float timeRemaining;

    public int doorsRemaining;

    public void doorEntered()
    {
        doorsRemaining--;
        UpdateText();

        if (doorsRemaining <= 0)
        {
            WinGame();
        }

        SpawnManager.instance.ClearAll();
        SpawnManager.instance.Populate();
    }

    private void Update() 
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateText();
        }
        else if (doorsRemaining > 0)
        {
            LoseGame();
        }
    }

    public void PlayerFailedToEnterDoor()
    {
        doorsRemaining++;
        UpdateText();

        SpawnManager.instance.ClearAll();
        SpawnManager.instance.Populate();
    }

    public void UpdateText()
    {
        timeRemainingText.text = "Time Remaining: " + ((int)timeRemaining).ToString();
        doorsRemainingText.text = "DoorsReamining " + doorsRemaining.ToString();
    }

    public void WinGame()
    {
        winPanel.SetActive(true);
    }

    public void LoseGame()
    {
        losePanel.SetActive(true);
    }
}
