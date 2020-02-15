using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
     * Warren Guiles
	 * HydraulicFists.cs
	 * Assignment 4
	 * This is a decorator for the robot fighter upgrade that increases speed and toughness, but decreases intelligence.
*/

public class HydraulicFists : RobotFighterDecorator
{
    public RobotFighter robotFighter;

    public HydraulicFists(RobotFighter newFighter)
    {
        this.robotFighter = newFighter;
    }

    public override string GetDescription()
    {
        return robotFighter.GetDescription() + ", armed with Hydraulic Fists";
    }

    public override string GetName()
    {
        return this.robotFighter.GetName();
    }

    public override int GetSpeed()
    {
        return robotFighter.GetSpeed() + 15;
    }

    public override int GetToughness()
    {
        return robotFighter.GetToughness() + 20;
    }

    public override int GetIntelligence()
    {
        return robotFighter.GetIntelligence() - 15;
    }

    
}
