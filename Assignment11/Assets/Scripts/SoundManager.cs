using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 /*
	 * Warren Guiles
	 * SoundManager.cs
	 * Assignment 11
	 * This script controls the sounds in the game. It's also
     one of the subsystems used in the facade setup.
 */
public class SoundManager : MonoBehaviour
{
    public AudioSource source;
    public AudioClip winClip;
    public AudioClip loseClip;

    public AudioClip swarmClip;
    

    public void PlayWinSound()
    {
        source.clip = winClip;
        source.Play();
    }

    public void LoseSound()
    {
        source.clip = loseClip;
        source.Play();
    }

    public void SwarmSound()
    {
        source.clip = swarmClip;
        source.Play();
    }
}
