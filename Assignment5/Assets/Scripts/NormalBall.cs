using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBall : Ball
{
    /*
 * Warren Guiles
 * Normal.cs
 * Assignment 5
 * This is a ball that inherits from the super ball class
 that is created through the factory pattern. This ball is a standard 
 one and therefore it does not have a special ability.
 */
    public override void Ability()
    {
        return; //no ability for the normal ball
    }
}
