using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCreator : GameCharacterFactory
{
    public override GameObject SpawnGameCharacter(string type)
    {
        GameObject objToReturn = null;

        if (type == "NormalPlayer")
            objToReturn = Resources.Load<GameObject>("NormalPlayer");
        else if (type == "FastPlayer")
            objToReturn = Resources.Load<GameObject>("FastPlayer");
        else if (type == "SmallPlayer")
            objToReturn = Resources.Load<GameObject>("SmallPlayer");


            objToReturn.GetComponent<GameCharacter>().ActivateAbility();

            return objToReturn;
    }
}
