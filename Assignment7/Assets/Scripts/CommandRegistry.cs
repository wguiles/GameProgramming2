using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    * Warren Guiles
    * CommandRegistry.cs
    * Assignment7.
    * This is the script that creates all of the commands in the game
    and assigns their receivers.
*/
public class CommandRegistry : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //assign player
        PopIntoBackgroundCommand playerPopsIntoBackground = new PopIntoBackgroundCommand(player);
        CommandManager.instance.AddCommand("PlayerBackground", playerPopsIntoBackground);

        //create save state machine
        SaveStateCommand saveStateDriver = new SaveStateCommand();
        CommandManager.instance.AddCommand("SaveStateDriver", saveStateDriver);
    }

}
