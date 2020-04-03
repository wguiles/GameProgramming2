using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public EnemyState currentState;
    
    public Transform player;

    public float pursuitDistance = 40f;

    public float enemyHealth;

    private bool inRange = false;


    // Start is called before the first frame update
    void Start()
    {
        currentState = new PatrolState();
        player = GameObject.FindWithTag("Player").transform;
         GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        currentState.Move(gameObject);
        currentState.Action(gameObject);

        CheckForStateChange();
    }

    public void CheckForStateChange()
    {
        if (Vector3.Distance(transform.position, player.position) <= pursuitDistance && !inRange)
        {
            currentState = new MoveTowardsPlayerState();
            StartCoroutine(MoveAndSpawnLoop());
            inRange = true;
        }
    }

    IEnumerator MoveAndSpawnLoop()
    {
        while(true)
        {
            yield return new WaitForSeconds(3.0f);
            currentState = new SpawnUnderlingsState();
            yield return new WaitForSeconds(2.0f);
            currentState = new MoveTowardsPlayerState();
        }

    }

    private void Death()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "bullet")
        {
            enemyHealth -= 1f;

            if (enemyHealth <= 0)
            {
                Death();
            }

            StartCoroutine(DamageIndication());
            Destroy(other.gameObject);
        }
    }
    private IEnumerator DamageIndication()
    {
        GetComponent<Renderer>().material.color = Color.white;
        yield return new WaitForSeconds(0.10f);
        GetComponent<Renderer>().material.color = Color.red;
    }
}
