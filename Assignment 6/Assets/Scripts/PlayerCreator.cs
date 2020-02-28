using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCreator : GameCharacterFactory
{

         /*
	 * Warren Guiles
	 * PlayerCreator.cs
	 * Assignment 6 
	 * This is one of the concrete classes that inherits from the 
     Game Character factory. This one specifically spawns different
    variations of the player
*/
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
