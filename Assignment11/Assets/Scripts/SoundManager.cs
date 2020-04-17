using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
