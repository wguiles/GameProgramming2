using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Warren Guiles
* EnemyManager.cs
* Assignment 1

* This is the driver class that is attached to an object in the scene. It creates instances of all the classes I made and tests their methods.
*/

namespace assignment1
{
    public class EnemyManager : MonoBehaviour
{

     public List<Enemy> enemies = new List<Enemy>();
     public List<IHasArmor> armoredEnemies = new List<IHasArmor>();

    void Start()
    {
        RangedEnemy archer = new RangedEnemy();
        archer.Attack();
        archer.TakeDamage();

        MeleeEnemy axeMan = new MeleeEnemy();
        axeMan.Attack();
        axeMan.TakeDamage();

        enemies.Add(archer);
        enemies.Add(axeMan);
        enemies.Add(new RangedEnemy());
        enemies.Add(new MeleeEnemy());

        armoredEnemies.Add(archer);
        armoredEnemies.Add(axeMan);
        armoredEnemies.Add(new RangedEnemy());
        armoredEnemies.Add(new MeleeEnemy());

        SupportEnemy shaman = new SupportEnemy();
        enemies.Add(shaman);
        armoredEnemies.Add(shaman);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach(Enemy enem in enemies)
            {
                enem.Attack();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach(IHasArmor armorEnem in armoredEnemies)
            {
                armorEnem.WeakenArmor();
            }
        }
    }
}
}

