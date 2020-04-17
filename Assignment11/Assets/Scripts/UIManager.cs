using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject winScreen;
    public GameObject loseScreen;

    public Image healthBar;

    public BossScript bossScript;

    private int healthMax;

    private void Start() 
    {
        healthMax = bossScript.GetHealth();
    }

    public void DisplayWinScreen()
    {
        winScreen.SetActive(true);
    }

    public void DisplayLoseScreen()
    {
        loseScreen.SetActive(true);
    }

    public void UpdateHealthBar()
    {
        healthBar.fillAmount = (float)((float)bossScript.GetHealth() / (float)healthMax);
    }
}
