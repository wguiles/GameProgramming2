using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 /*
	 * Warren Guiles
	 * EnemyCreator.cs
	 * Assignment 6 
	 * This is a concrete class that inherits from my abstract game 
     character factory. This specifically allows for spawning different
     types of enemies from the resources folder.
*/
public class EnemyCreator : GameCharacterFactory
{
    public override GameObject SpawnGameCharacter(string type)
    {
        GameObject objToReturn = null;

        if (type == "HorizontalEnemy")
            objToReturn = Resources.Load<GameObject>("HorizontalEnemy");
        else if (type == "VerticalEnemy")
            objToReturn = Resources.Load<GameObject>("VerticalEnemy");

            return objToReturn;
    }
}
