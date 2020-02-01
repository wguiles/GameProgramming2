using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class uiManager : MonoBehaviour
{
     /*
		 * Warren Guiles
		 * uiManager.cs
		 * Assignment 2
		 * This scripts contain methods to switch the scene as well as references 
         to the victory/defeat panels for the game.
	*/
    public static uiManager instance;

    private void Awake() 
    {
        if (instance == null)
            instance = this;
    }

    public GameObject victoryPanel;

    public GameObject defeatPanel;


    public void LoadScene(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void DisplayVictoryPanel()
    {
        Debug.Log("Victory panel being displayed");
        victoryPanel.SetActive(true);
    }

    public void DisplayDefeatPanel()
    {
        defeatPanel.SetActive(true);
    }
}
