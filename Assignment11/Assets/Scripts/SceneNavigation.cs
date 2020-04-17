using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigation : MonoBehaviour
{
    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
}
