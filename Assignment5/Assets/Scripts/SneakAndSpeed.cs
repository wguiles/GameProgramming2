using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SneakAndSpeed : Ball
{

       /*
    * Warren Guiles
    * SneakAndSpeed.cs
     * Assignment 5
    * This is a ball that inherits from the super ball class
    that is created through the factory pattern. This ball starts off
    slow and moves a little faster after a second
    */

    private float initialspeed;
    public float secondsToWait;

    public override void Ability()
    {
        Debug.Log("Ability called in sneak and speed");
        Invoke("SpeedUp", secondsToWait);
    }

    private void SpeedUp()
    {
        this.speed *= 4f;
    }
}
