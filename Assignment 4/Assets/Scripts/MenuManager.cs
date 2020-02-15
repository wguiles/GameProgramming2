using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

/*
     * Warren Guiles
	 * MenuManager.cs
	 * Assignment 4
	 * This is a really simple script that allows me to load scenes based on a string.
*/
    public void SceneLoad(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
