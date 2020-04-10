using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnwer : MonoBehaviour
{
    public float spawnRate;
    private float currentTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTimer += Time.deltaTime * spawnRate;

        if (currentTimer >= 1)
        {
            currentTimer = 0f;
            SpawnEnemy();
        }
    }

    public void SpawnEnemy()
    {
        GameObject newObj = ObjectPooler.instance.SpawnFromPool("Enemy", GetRandomSpawnPosition(), Quaternion.identity);
        EnemyScript enemy = newObj.GetComponent<EnemyScript>();
        enemy.SetRandomVelocity();
    }

    private Vector2 GetRandomSpawnPosition()
    {
        //50/50 chance the object will come in from the sides of the screen, or the topOrBottom
        int SpawnCoinFlip = Random.Range(0,2);
        int SideCoinFlip = Random.Range(0,2);
        Vector2 randomPos;

        float randomX = 0f;
        float randomY = 0f;

        if (SpawnCoinFlip == 1)
        {
            //spawn on either left or right side
             randomX = Random.Range(12f,15f);

            if (SideCoinFlip == 0)
            {
                randomX *= -1f;
            }

             randomY = Random.Range(-7f, 7f);

        }
        else if (SpawnCoinFlip == 0)
        {
             randomX = Random.Range(-11f,11f);

             randomY = Random.Range(8f, 10f);

            if (SideCoinFlip == 0)
            {
                randomY *= -1f;
            }
        }

        randomPos = new Vector2(randomX, randomY);

        return randomPos;

    }

    
}
