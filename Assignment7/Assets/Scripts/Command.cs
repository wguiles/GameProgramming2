using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    * Warren Guiles
    * Command.cs
    * Assignment7.
    * This is the top level interface for all of the commands in the codebase.
*/
public interface Command
{
    void execute();

    void undo();
}
