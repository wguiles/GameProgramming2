using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
        /*
	 * Warren Guiles
	 * MenuManager.cs
	 * Assignment 3
	 * This is a small script I made to load scenes on command, so I 
     could attach them to the buttons in the UI.

	 */
    public void LoadScene(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }  
}
