using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwinIonEngine : RobotFighterDecorator
{
    /*
     * Warren Guiles
	 * TwinIonEngine.cs
	 * Assignment 4
	 * This is a decorator for the robot fighter upgrade that increases speed, but
     also decreases toughness
*/
    public RobotFighter robotFighter;

    public TwinIonEngine(RobotFighter newFighter)
    {
        this.robotFighter = newFighter;
    }

    public override string GetDescription()
    {
        return robotFighter.GetDescription() + ", fused with twin ion engine";
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
        return robotFighter.GetToughness() - 10;
    }

    public override int GetIntelligence()
    {
        return robotFighter.GetIntelligence();
    }



 

}
