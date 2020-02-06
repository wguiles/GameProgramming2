using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossUIScript : MonoBehaviour, IBossNode
{
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
