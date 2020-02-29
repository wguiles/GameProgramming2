using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameCharacter : MonoBehaviour
{

        /*
	 * Warren Guiles
	 * GameCharacter.cs
	 * Assignment 6 
     * This is the abstract class for the things that get 
     spawned from the factory
*/
    public abstract void SetPosition(Vector2 newPos);

    public abstract void Die();

    public abstract void Move();

    public abstract void ActivateAbility();
}
