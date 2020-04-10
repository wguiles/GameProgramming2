using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    //Text
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI scoreText;

    public GameObject winPanel;
    public GameObject lossPanel;

    public GameObject outOfTimePanel;


    public static GameManager instance;

     private void Awake() 
     {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Update() 
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = "Time Left: " + ((int)timeLeft).ToString();
        }
        else if (money < requiredMoney)
        {
            DisplayOutOfTimePanel();
        }
    }

    private int money = 0;

    public int requiredMoney;

    public float timeLeft;

    public void collectMoney()
    {
        money++;

        scoreText.text = "Score: " + money.ToString();

        if (money >= requiredMoney)
        {
            DisplayWinPanel();
        }
    }

    public void DisplayWinPanel()
    {
        winPanel.SetActive(true);
    }

    public void DisplayLossPanel()
    {
        lossPanel.SetActive(true);
    }

    public void DisplayOutOfTimePanel()
    {
        outOfTimePanel.SetActive(true);
    }
}
