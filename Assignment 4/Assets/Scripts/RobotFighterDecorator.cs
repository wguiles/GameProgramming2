using System.Collections;
using System.Collections.Generic;
using UnityEngine;


     
    //  Warren Guiles
	//  RobotFighterDecorator.cs
	//  Assignment 4
	//  This is the base interface that all the decorators in my game inherit from. It has abstract getters
    //for description and basic name.

public abstract class RobotFighterDecorator : RobotFighter
{
    public override abstract string GetDescription();
    public override abstract string GetName();
}
