using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    /*
		 * Warren Guiles
		 * UIManager
		 * Assignment 9
		 * This script handles displaying win and loss panels 
         based on the win/loss state
	*/
public static UIManager instance;

public GameObject winPanel;
public GameObject losePanel;

    private void Awake() 
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void LoadScene(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void DisplayWinPanel()
    {
        winPanel.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }

    public void DisplayLosePanel()
    {
        losePanel.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }
}
