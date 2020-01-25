using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Warren Guiles
* SupportEnemy.cs
* Assignment 1

* This is a class that derives from enemy. It's meant to represent
  a support enemy that would heal nearby enemies. It overrides methods 
  for TakeDamage and Attack, while also implementing methods 
  from IHasArmor and IPoolerObject
*/
namespace assignment1
{
    public class SupportEnemy: Enemy, IHasArmor, IPoolerObject
    {
        public override void Attack()
        {
            Heal();
        }

        private void Heal()
        {
            Debug.Log("Support Enemy heals all nearby enemies!");
        }

        public override void TakeDamage()
        {
            Debug.Log("Support enemy is killed instantly!");
        }

        public void WeakenArmor()
        {
            Debug.Log("Return. Support Enemy has no armor");
        }

        public void BreakArmor()
        {
            Debug.Log("Return. Support Enemy has no armor");
        }

        public void SpawnFromPool()
        {
            Debug.Log("Support Enemy was spawned from object pool.");
        }
    }
}

