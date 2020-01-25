using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
* Warren Guiles
* MeleeEnemy.cs
* Assignment 1

* This is a class that derives from enemy. It's meant to represent
  a close range enemy with melee attacks. It overrides methods 
  for TakeDamage and Attack, while also implementing methods 
  from IHasArmor and IPoolerObject
*/
namespace assignment1
{
public class MeleeEnemy : Enemy, IHasArmor, IPoolerObject
{
    protected int health;
    
    public override void TakeDamage()
    {
        Debug.Log("Melee Enemy is more Tanky and takes less damage");
    }

    public override void Attack()
    {
        Debug.Log("Melee Enemy Stabs!");
    }

    public void WeakenArmor()
    {
         Debug.Log("One of Melee Enemy's several layers of armor is weakened!");
    }

    public void BreakArmor()
    {
        Debug.Log("Melee Enemy's armor is broken!");
    }

    public void SpawnFromPool()
    {
        Debug.Log("Melee Enemy was spawned from object pool.");
    }
}
}

