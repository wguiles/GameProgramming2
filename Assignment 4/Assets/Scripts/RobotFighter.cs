using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
     * Warren Guiles
	 * RobotFighter.cs
	 * Assignment 4
	 * This is the base interface that all classes inherit from. It contains the abstract methods for 
     * receiving the toughess, speed, and intelligence of the robot fighter. I also have getters for
     the description and basic name of the robot
     
*/

public abstract class RobotFighter
{

    public string description = " ";

    public string name = " ";


    public abstract int GetToughness();

    public abstract int GetIntelligence();

    public abstract int GetSpeed();

    public int health = 100;

    

    public virtual string GetDescription()
    {
        return description;
    }

    public virtual string GetName()
    {
        return name;
    }




}
