using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Warren Guiles
 * BallFactory.cs
 * Assignment 5
 * This is the factory script itself that returns a certain type of object
 based on a key that was sent in by the creator script that acesses it
 (in this case it's BallCreator). This specifically return a prefab
 based on the string that was passed through by the BallCreator
 */

public class BallFactory : MonoBehaviour
{
    public GameObject NormalPrefab;
    public GameObject SneakAndSpeedPrefab;
    public GameObject SlowStunPrefab;


    public GameObject GenerateBall(string type)
    {
        GameObject ballToSpawn = null;

        if (type == "Normal")
        {
            ballToSpawn = NormalPrefab;
        }
        else if (type == "SneakAndSpeed")
        {
            ballToSpawn = SneakAndSpeedPrefab;
        }
        else if (type == "SlowStun")
        {
            ballToSpawn = SlowStunPrefab;
        }

        return ballToSpawn;
    }
}
