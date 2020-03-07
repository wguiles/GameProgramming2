using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/*
    * Warren Guiles
    * PlayerBehaviour.cs
    * Assignment7
    * This script handles the win and lose panel for the game, while
    also displaying text for save states.
*/

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject SaveStatePanel;

    public TextMeshProUGUI saveStateText;

    public GameObject losePanel;
    public GameObject winPanel;
    

    private void Awake() 
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void ShowSaveStateMessage(string Message)
    {
        saveStateText.text = Message;
        StartCoroutine(timedMessageShow());
    }

    private IEnumerator timedMessageShow()
    {
        SaveStatePanel.SetActive(true);
        yield return new WaitForSeconds(4.0f);
        SaveStatePanel.SetActive(false);
    }

    public void DeactivateLosePanel()
    {
        losePanel.SetActive(false);
    }

    public void ActivateWinPanel()
    {
        winPanel.SetActive(true);
    }


}
