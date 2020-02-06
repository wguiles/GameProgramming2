using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossNode : MonoBehaviour, IBossNode
{
    public int nodeHealth;
    private INodeBehaviour behaviour;

    private int initialHealth;

    public GameObject enemyBullet;

    private Transform bulletOrigin;

    private void Start() 
    {
        initialHealth = nodeHealth;
        bulletOrigin = transform.GetChild(0).transform;
        behaviour = new DoNothing();
    }

    private void Update() 
    {
        activateNodeBehaviour();
    }

    public GameObject GetGameObject()
    {
        return gameObject;
    }


    public void activateNodeBehaviour()
    {
        behaviour.attack(gameObject);
    }

    public void updateBehaviour(int healthRemaining)
    {
        if (healthRemaining <= 40 && healthRemaining >= 30)
        {
            setNodeBehaviour(new Shoot());
        }
        else if (healthRemaining <= 30)
        {
            setNodeBehaviour(new Bob());
        }
    }

    public void setNodeBehaviour(INodeBehaviour newBehaviour)
    {
        behaviour = newBehaviour;
    }

    public int GetHealth()
    {
        return nodeHealth;
    }

    public void SetHealth(int newHealth)
    {
        nodeHealth = newHealth;
    }

    public void TakeDamage(int damageToTake)
    {
        nodeHealth -= damageToTake;

        StopCoroutine(DamageFlash());
        StartCoroutine(DamageFlash());
        
        if (nodeHealth <= 0)
        {
            Deactivate();
        }
    }

    private IEnumerator DamageFlash()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        yield return new WaitForSeconds(0.09f);
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    private void Deactivate()
    {
        nodeHealth = initialHealth;
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Bullet")
        {
            TakeDamage(1);
            Destroy(other.gameObject);
        }
    }

    public Transform GetBulletOriginPoint()
    {
        return bulletOrigin;
    }
}
