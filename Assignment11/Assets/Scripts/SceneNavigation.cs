using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 /*
	 * Warren Guiles
	 * SceneNavigation.cs
	 * Assignment 11
	 * this is a basic script that allows me to switch scenes
 */
public class SceneNavigation : MonoBehaviour
{
    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
}
