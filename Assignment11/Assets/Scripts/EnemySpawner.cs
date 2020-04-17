using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;


    private void Start() 
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnSwarm()
    {
        for (int i = 0; i < 8; i ++)
        {
            GameObject g = Instantiate(enemy, transform.position + randomOffset(), Quaternion.identity);
            BugEnemy newEnemy = g.GetComponent<BugEnemy>();
            StartCoroutine(delayedActivation(newEnemy));
        }
    }

    private IEnumerator delayedActivation(BugEnemy enemyToMove)
    {
        yield return new WaitForSeconds(2.0f);

        if (enemyToMove != null)
        {           
            enemyToMove.SetRandomSpeed();
            enemyToMove.SetDestination();
        }

    }

    private Vector3 randomOffset()
    {
        return new Vector3(Random.Range(-8f, 8f), 0f, 0f);
    }

}
