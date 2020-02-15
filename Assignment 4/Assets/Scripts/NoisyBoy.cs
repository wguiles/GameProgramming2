using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
     * Warren Guiles
	 * NoisyBoy.cs
	 * Assignment 4
	 * This is one of the concrete classes that the decorators get wrapped around. This one specifically
     * is a robot build that has middle intelligence and Toughness, but low speed
*/

public class NoisyBoy: RobotFighter
{
    public NoisyBoy()
    {
        description = "Noisy Boy";
        name = "Noisy Boy";
    }

    public override int GetSpeed()
    {
        return 25;
    }

    public override int GetIntelligence()
    {
        return 40;
    }

    public override int GetToughness()
    {
        return 45;
    }
}