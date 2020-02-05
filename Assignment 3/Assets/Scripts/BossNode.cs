using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossNode : MonoBehaviour, IBossNode
{
    public int nodeHealth;
    private INodeBehaviour behaviour;



    public GameObject GetGameObject()
    {
        return gameObject;
    }


    public void activateNodeBehaviour()
    {
        behaviour.attack();
    }

    public void updateBehaviour(int healthRemaining)
    {
        //switch node Behaviour based on how much health the boss has left
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
    }
}
