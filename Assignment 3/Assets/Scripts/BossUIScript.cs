using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossUIScript : MonoBehaviour, IBossNode
{
     /*
	 * Warren Guiles
	 * BossUIScript.cs
	 * Assignment 3
	 * This is one of the observer classes that recieves information from 
     the subject. This script receives the health from the Subject,
     and gives it a visual representation on the screen via 
     the health bar in the top right
	 */

    public Image bossHealthBar;
    

    public GameObject GetGameObject()
    {
        return null;
    }

    public void updateBehaviour(int healthReamining)
    {
        bossHealthBar.fillAmount = ((float)healthReamining / 60f);
    }


}
