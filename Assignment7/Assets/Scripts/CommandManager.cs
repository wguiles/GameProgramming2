using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
    * Warren Guiles
    * CommandManager.cs
    * Assignment7
    * This is the manager that contains a dictionary of all of the commands in the game.
    It has functionality to execute and undo commands by accessing the dictionary 
    via a string.
*/
public class CommandManager : MonoBehaviour
{
    public static CommandManager instance;

    private void Awake() 
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public Dictionary<string, Command> commands = new Dictionary<string, Command>();

    public void AddCommand(string commandName, Command newCommand)
    {
        commands.Add(commandName, newCommand);
    }

    public void ExecuteCommand(string commandName)
    {
        Debug.Log("ExecuteCalled");
        foreach(KeyValuePair<string, Command> c in commands)
        {
            if (commandName == c.Key)
            {
                 c.Value.execute();
            }
        }
    }

    public void UndoCommand(string commandName)
    {
        foreach(KeyValuePair<string, Command> c in commands)
        {
             if (commandName == c.Key)
            {
                 c.Value.undo();
            }
        }
    }
}
