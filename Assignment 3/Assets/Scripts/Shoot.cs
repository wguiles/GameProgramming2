using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour, INodeBehaviour
{

    private float currentTimer;

    private float fireRate = 0.75f;

    public void attack(GameObject nodeObject)
    {
        currentTimer += Time.deltaTime;

        if (currentTimer >= fireRate)
        {
            
             GameObject newBullet = Instantiate(nodeObject.GetComponent<BossNode>().enemyBullet, nodeObject.transform.position, Quaternion.identity);
             newBullet.tag = "EnemyBullet";
             currentTimer = 0f;

             newBullet.GetComponent<BulletScript>().bulletSpeed = 5f;

             newBullet.GetComponent<BulletScript>().SetDirection(nodeObject.GetComponent<BossNode>().GetBulletOriginPoint().right);
             newBullet.transform.localScale *= 2f;
        }

    }
}
