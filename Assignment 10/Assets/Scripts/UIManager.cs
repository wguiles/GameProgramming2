using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


   /*
	* Warren Guiles
	 * UIManager
	 * Assignment 10
	 * This script handles changing scenes.
 */

public class UIManager : MonoBehaviour
{
    public void LoadSceneByString(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
