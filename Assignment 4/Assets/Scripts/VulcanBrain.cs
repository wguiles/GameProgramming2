using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VulcanBrain : RobotFighterDecorator
{

/*
     * Warren Guiles
	 * HydraulicFists.cs
	 * Assignment 4
	 * This is a decorator for the robot fighter upgrade that increases intelligence greatly, but
     also decreases speed and toughness
*/

    public RobotFighter robotFighter;

    public VulcanBrain(RobotFighter newFighter)
    {
        this.robotFighter = newFighter;
    }

    public override string GetDescription()
    {
        return robotFighter.GetDescription() + ", implanted with a vulcan's brain";
    }

    public override int GetSpeed()
    {
        return robotFighter.GetSpeed() - 10;
    }

    public override int GetToughness()
    {
        return robotFighter.GetToughness() - 10;
    }

    public override int GetIntelligence()
    {
        return robotFighter.GetIntelligence() + 30;
    }

    public override string GetName()
    {
        return this.robotFighter.GetName();
    }

    
}
