using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandRegistry : MonoBehaviour
{
    public GameObject player;
    public GameObject[] enemies;

    // Start is called before the first frame update
    void Start()
    {
        //assign player
        PopIntoBackgroundCommand playerPopsIntoBackground = new PopIntoBackgroundCommand(player);
        CommandManager.instance.AddCommand("PlayerBackground", playerPopsIntoBackground);

        //create save state machine
        SaveStateCommand saveStateDriver = new SaveStateCommand();
        CommandManager.instance.AddCommand("SaveStateDriver", saveStateDriver);


         foreach(GameObject g in enemies)
        {
            EnemyPopsIntoBackgroundCommand enemyCommand = new EnemyPopsIntoBackgroundCommand(g);

             CommandManager.instance.AddCommand(g.name, enemyCommand);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
