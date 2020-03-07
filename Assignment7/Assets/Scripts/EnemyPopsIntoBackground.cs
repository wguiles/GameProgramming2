using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPopsIntoBackgroundCommand : Command
{

    /*[DEPRECATED]
    * Warren Guiles
    * EnemyPopsIntoBackgroundCommand.cs
    * Assignment7
    * This is a command that allowed the enemies to change color and move
    through various obstacles. Due to time restraints, I cut it from 
    the current project.
*/

     public GameObject receiver;

    public EnemyPopsIntoBackgroundCommand(GameObject newReceiver)
    {
        receiver = newReceiver;
    }

    public void execute()
    {
        Debug.Log("Pop Into Background communicated");
        receiver.GetComponent<SpriteRenderer>().color = Color.blue;

        receiver.gameObject.layer = 9;

        foreach(Transform child in receiver.transform)
        {
            child.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
        }
    }

    public void undo()
    {
        receiver.GetComponent<SpriteRenderer>().color = Color.yellow;
        receiver.gameObject.layer = 8;

        foreach(Transform child in receiver.transform)
        {
            child.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.9716981f, 0.5727382f, 0.03208439f, 1.0f);
        }

    }
}
