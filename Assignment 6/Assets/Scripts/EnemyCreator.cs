using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
