using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
* Warren Guiles
* RangedEnemy.cs
* Assignment 1

* This is a class that derives from enemy. It's meant to represent
  a long range enemy with shooting attacks. It overrides methods 
  for TakeDamage and Attack, while also implementing methods 
  from IHasArmor and IPoolerObject
*/
namespace assignment1
{
    public class RangedEnemy : Enemy, IHasArmor, IPoolerObject
    {

    protected int health;
    
     public override void TakeDamage()
    {
        Debug.Log("Ranged Enemy takes more damage than a standard melee enemy.");
    }

    public override void Attack()
    {
        Debug.Log("Ranged Enemy Shoots!");
    }

    public void WeakenArmor()
    {
        Debug.Log("Ranged Enemy's armor is weakened! Ranged enemy doesn't have much armor left.");
    }

    public void BreakArmor()
    {
        Debug.Log("Ranged Enemy's armor is broken!");
    }

    public void SpawnFromPool()
    {
        Debug.Log("Ranged Enemy was spawned from object pool.");
    }
}
}

