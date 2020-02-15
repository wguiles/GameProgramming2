using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
     * Warren Guiles
	 * LilDipper.cs
	 * Assignment 4
	 * This is one of the concrete classes that the decorators get wrapped around. This one specifically
     * is a robot build that has middle intelligence, high speed, and low toughness.
*/

public class LilDipper: RobotFighter
{
    public LilDipper()
    {
        description = "Lil Dipper";
        name = "Lil Dipper";
    }

    public override int GetSpeed()
    {
        return 55;
    }

    public override int GetIntelligence()
    {
        return 45;
    }

    public override int GetToughness()
    {
        return 25;
    }


}
