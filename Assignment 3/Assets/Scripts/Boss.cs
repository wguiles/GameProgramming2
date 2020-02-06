using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour, IBoss
{
    public int bossHealth;

    public List<IBossNode> bossNodeList = new List<IBossNode>();

    public GameObject VictorPanel;


    private void Start() 
    {
        init();    
        StartCoroutine(nodeRegenTimer());
    }

    private IEnumerator DamageFlash()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        yield return new WaitForSeconds(0.09f);
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    public void init()
    {
       registerNode(GetComponent<BossBehaviour>());
       registerNode(FindObjectOfType<BossUIScript>());
       
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
            if (node.GetGameObject() != null)
            {
                 node.GetGameObject().SetActive(true);
                 node.GetGameObject().GetComponent<SpriteRenderer>().color = Color.white;
            }

        }
    }

    IEnumerator nodeRegenTimer()
    {
        while(true)
        {
             yield return new WaitForSeconds(10f);
             reviveAllNodes();
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
        StopCoroutine(DamageFlash());

        StartCoroutine(DamageFlash());

        bossHealth -= damageToTake;

        updateNode(bossHealth);

        if (bossHealth <= 0)
        {
            Death();
        }
    }

    private void DestroyAllNodes()
    {
         foreach(IBossNode node in bossNodeList)
        {
            if (node.GetGameObject() != null)
            {
                 Destroy(node.GetGameObject());
            }
        }
    }

    public void Death()
    {
        DestroyAllNodes();
        Destroy(gameObject);
        VictorPanel.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Bullet")
        {
            Debug.Log("Got hit by bullet");
            TakeDamage(1);
            Destroy(other.gameObject);
        }    
    }

    
}
