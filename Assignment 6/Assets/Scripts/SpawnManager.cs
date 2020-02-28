using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
         /*
	 * Warren Guiles
	 * SpawnManager.cs
	 * Assignment 6 
	 * This is the script that calls the factory methods and 
     randomly populates the screen with enemies and doors randomly
*/

    private EnemyCreator enemyCreator;

    private PlayerCreator playerCreator;

    public GameObject player;
    public List<GameObject> doors;

    public List<GameObject> enemies;

    public GameObject[] doorSpawnPoints;

    public GameObject[] enemySpawnPoints;

    public GameObject normalDoor;
    public GameObject fastDoor;
    public GameObject smallDoor;


    public static SpawnManager instance;

    public Door.doorType type = Door.doorType.normal;

    private void Awake() 
    {
        if (instance == null)
        {
            instance = this;
        }
    }

     private void Start() 
    {
        enemyCreator = new EnemyCreator();
        playerCreator = new PlayerCreator();

        enemySpawnPoints = GameObject.FindGameObjectsWithTag("EnemySpawn");
        doorSpawnPoints  = GameObject.FindGameObjectsWithTag("DoorSpawn");

        Populate();
    }

    public void SetType (Door.doorType newType)
    {
        type = newType;
    }

    public void SpawnNextPlayer()
    {
        GameObject newPlayer = null;

        if (type == Door.doorType.normal)
        {
            newPlayer = Instantiate(playerCreator.SpawnGameCharacter("NormalPlayer"), new Vector2(0f, -1f), Quaternion.identity);
        }
        else if (type == Door.doorType.fast)
        {
            newPlayer = Instantiate(playerCreator.SpawnGameCharacter("FastPlayer"), new Vector2(0f, -1f), Quaternion.identity);
        }
        else if (type == Door.doorType.small)
        {
            newPlayer = Instantiate(playerCreator.SpawnGameCharacter("SmallPlayer"), new Vector2(0f, -1f), Quaternion.identity);
        }

        player = newPlayer;
    }

    public void Populate()
    {
        //Spawn player in center
        SpawnNextPlayer();

        //randomly place enemies

        int enemiesToSpawn = 5;

        for(int i = 0; i < enemySpawnPoints.Length; i++)
        {
            float randomNum = Random.Range(0f,1f);

            if (randomNum <= 0.25f)
            {
                int randomNum2 = Random.Range(0,2);
                GameObject newEnemy;

                if (randomNum2 == 0)
                {
                    newEnemy = enemyCreator.SpawnGameCharacter("HorizontalEnemy");
                }
                else
                {
                    newEnemy = enemyCreator.SpawnGameCharacter("VerticalEnemy");
                }

                GameCharacter character = (Instantiate(newEnemy, transform.position, Quaternion.identity)).GetComponent<GameCharacter>();

                enemies.Add(character.gameObject);
                
                character.SetPosition(enemySpawnPoints[i].transform.position);

                character.ActivateAbility();
                enemiesToSpawn--;

                if (enemiesToSpawn == 0)
                    break;
            }
        }

        //randomlyPlaceDoors
    int doorsToSpawn = 2;
        for(int i = 0; i < doorSpawnPoints.Length; i++)
        {
            

            float randomNum = Random.Range(0f,1f);
            if (randomNum <= 0.5f)
            {
                int randomNum2 = Random.Range(0,3);
                GameObject doorToSpawn = null;

                if (randomNum2 == 0)
                {
                    doorToSpawn = Instantiate(normalDoor, doorSpawnPoints[i].transform.position + new Vector3(0f, 0.5f), Quaternion.identity);
                }
                else if (randomNum2 == 1)
                {
                    doorToSpawn = Instantiate(fastDoor, doorSpawnPoints[i].transform.position + new Vector3(0f, 0.5f), Quaternion.identity);
                }
                else if (randomNum2 == 2)
                {
                    doorToSpawn = Instantiate(smallDoor, doorSpawnPoints[i].transform.position + new Vector3(0f, 0.5f), Quaternion.identity);
                }

                doors.Add(doorToSpawn);

                doorsToSpawn--;

                if (doorsToSpawn == 0)
                    break;

             }
        }


}

    public void ClearAll()
    {
        Destroy(player);

        foreach(GameObject g in enemies)
        {
            Destroy(g);
        }

        foreach(GameObject g in doors)
        {
            Destroy(g);
        }

        enemies.Clear();
        doors.Clear();
    }
}
