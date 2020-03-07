using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
    * Warren Guiles
    * SaveStateCommand.cs
    * Assignment7
    * This script keeps a stack of lists of SavableObjects in order to store 
    the position, layer, and color of every dynamic entity in the game via 
    the execute method. When the command is undone, the stack is popped
    to revert all movable entities to the last state they were at.
*/
public class SaveStateCommand : Command
{
    public Stack<List<SavableObject>> savables = new Stack<List<SavableObject>>();

    public void execute()
    {
        UIManager.instance.ShowSaveStateMessage("State Saved");
        List<SavableObject> newList = new List<SavableObject>();

        foreach (MonoBehaviour m in UnityEngine.Object.FindObjectsOfType<MonoBehaviour>())
        {
            ISavableObject interfaceCheck = m.GetComponent<ISavableObject>();

            if (interfaceCheck == null)
                continue;

            SavableObject temp = new SavableObject();

            temp.savedPosition = interfaceCheck.GetTransform().position;
            temp.savedObject   = interfaceCheck.GetObject();
            temp.savedSpriteColor  = temp.savedObject.GetComponent<SpriteRenderer>().color;
            temp.savedLayer = interfaceCheck.GetLayer();

            newList.Add(temp);
        }

        savables.Push(newList);
    }

    public void undo()
    {
        Debug.Log("Undid");

        if (savables.Count == 0)
        {
            UIManager.instance.ShowSaveStateMessage("No Saves Left");
            return;
        }
            
        
        List<SavableObject> oldStates = savables.Pop();

        foreach(SavableObject obj in oldStates)
        {
            obj.savedObject.transform.position = obj.savedPosition;
            obj.savedObject.layer = obj.savedLayer;
            obj.savedObject.GetComponent<SpriteRenderer>().color = obj.savedSpriteColor;
        }

        UIManager.instance.ShowSaveStateMessage("State Loaded");
        UIManager.instance.DeactivateLosePanel();
    }
}
