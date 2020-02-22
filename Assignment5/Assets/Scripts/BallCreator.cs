using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Warren Guiles
 * BallCreator.cs
 * Assignment 5
 * This is the script that references the factory in order to create things
    by calling methods from said factory. It receives info from the player
    in order to spawn the correct ball, as well as which direction the ball
    should go in.
 */

public class BallCreator : MonoBehaviour
{
    private BallFactory factory;

    private void Awake() 
    {
        factory = GetComponent<BallFactory>();
    }

    public void SpawnBall(string type, Vector2 positionToSpawn, Vector2 initialDirection)
    {
        GameObject newBall = Instantiate(factory.GenerateBall(type), positionToSpawn, Quaternion.identity);

        Ball newBallScript = newBall.GetComponent<Ball>();

        newBallScript.SetDirection(initialDirection);

        newBallScript.Ability();
    }


}
