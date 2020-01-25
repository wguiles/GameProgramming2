using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
* Warren Guiles
* Enemy.cs
* Assignment 1
* This is the abstract enemy class that SupportEnemy, MeleeEnemy, and RangedEnemy derive from.
*/

namespace assignment1
{
    public abstract class Enemy
{
    public abstract void Attack();
    
    public abstract void TakeDamage();
}
}

