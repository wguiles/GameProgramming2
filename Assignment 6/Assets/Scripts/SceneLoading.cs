using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
     /*
	 * Warren Guiles
	 * SceneLoading.cs
	 * Assignment 6 
	 * This is a variation of the player that gets spawned 
     by the factory. This version is faster than the normal player
*/
    public void LoadSceneByString(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
