using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameCharacterFactory : MonoBehaviour
{

/*
	 * Warren Guiles
	 * GameCharacterFactory.cs
	 * Assignment 6 
     * This is the abstract class that all things that spawn from the 
     factory inherit from. 
*/
    
    
    
    public abstract GameObject SpawnGameCharacter(string type);
}
