using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zeus: RobotFighter
{

    /*
     * Warren Guiles
	 * Zeus.cs
	 * Assignment 4
	 * This is one of the concrete classes that the decorators get wrapped around. This one specifically
     * is a robot build that has low intelligence, low speed, and huge toughness.
    */

    public Zeus()
    {
        description = "Zeus";
        name = "Zeus";
    }

    public override int GetSpeed()
    {
        return 25;
    }

    public override int GetIntelligence()
    {
        return 30;
    }

    public override int GetToughness()
    {
        return 60;
    }
}
