using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour, IBoss
{
    public int bossHealth;

    public List<IBossNode> bossNodeList = new List<IBossNode>();


    private void Start() 
    {
        init();    
    }

    public void init()
    {
       registerNode(GetComponent<BossBehaviour>());
       
       foreach(Transform node in transform.GetChild(0).gameObject.GetComponentInChildren<Transform>())
       {
           registerNode(node.GetComponent<IBossNode>());
       }

       Debug.Log(bossNodeList.Count.ToString());

       updateNode(bossHealth);
    }

    public void registerNode(IBossNode nodeToRegister)
    {
        bossNodeList.Add(nodeToRegister);
    }

    public void removeNode(IBossNode nodeToRemove)
    {
        bossNodeList.Remove(nodeToRemove);
    }

    public void updateNode(int healthRemaining)
    {
        foreach(IBossNode node in bossNodeList)
        {
            node.updateBehaviour(healthRemaining);
        }
    }

    public void reviveAllNodes()
    {
        foreach(IBossNode node in bossNodeList)
        {
            node.GetGameObject().SetActive(true);
        }
    }

    public int GetHealth()
    {
        return bossHealth;
    }

    public void SetHealth(int newHealth)
    {
        bossHealth = newHealth;
    }

    public void TakeDamage(int damageToTake)
    {
        bossHealth -= damageToTake;

        updateNode(bossHealth);
    }

    
}
