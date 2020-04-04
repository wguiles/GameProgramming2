using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class underlingScript : MonoBehaviour
{
    public EnemyState currentState;
    public float enemyHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentState = new MoveTowardsPlayerState();
    }

    // Update is called once per frame
    void Update()
    {
        currentState.Move(gameObject);
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

    public void Death()
    {

        Destroy(gameObject);
    }
}
