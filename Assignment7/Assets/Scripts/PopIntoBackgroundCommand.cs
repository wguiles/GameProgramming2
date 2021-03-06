﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopIntoBackgroundCommand : Command
{
    /*
    * Warren Guiles
    * PopIntoBackgroundCommand.cs
    * Assignment7
    * This command allows the reciever to "Pop into the background" by
    changing it's color and collision layer so that it can pass through
    ceratin obstacles.
*/
    public GameObject receiver;

    public PopIntoBackgroundCommand(GameObject newReceiver)
    {
        receiver = newReceiver;
    }

    public void execute()
    {
        Debug.Log("Pop Into Background communicated");
        receiver.GetComponent<SpriteRenderer>().color = Color.blue;

        receiver.gameObject.layer = 9;
    }

    public void undo()
    {

        receiver.GetComponent<SpriteRenderer>().color = new Color(0.9716981f, 0.5727382f, 0.03208439f, 1.0f);
        receiver.gameObject.layer = 8;

    }


}
