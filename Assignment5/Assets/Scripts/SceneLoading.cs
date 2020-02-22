using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
       /*
 * Warren Guiles
 * SceneLoading.cs
 * Assignment 5
 * This is a script that I attach to buttons to make navigation simple. It's a public method 
 that loads a scene based on a string passed through
 */
    public void LoadAScene(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
