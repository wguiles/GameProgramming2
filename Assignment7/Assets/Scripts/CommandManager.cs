using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
