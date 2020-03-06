using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SaveStateCommand : Command
{
    public Stack<List<SavableObject>> savables = new Stack<List<SavableObject>>();

    public void execute()
    {
        Debug.Log("Executed");
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
            return;
        
        List<SavableObject> oldStates = savables.Pop();

        foreach(SavableObject obj in oldStates)
        {
            obj.savedObject.transform.position = obj.savedPosition;
            obj.savedObject.layer = obj.savedLayer;
            obj.savedObject.GetComponent<SpriteRenderer>().color = obj.savedSpriteColor;
        }
    }
}
