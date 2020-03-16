using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
	 * Warren Guiles
	 * ShootGrunt.cs
	 * Assignment 8
	* This script handles one of the enemies that uses the abstract enemy template. It's
    attack method uses the method shoot to shoot every few seconds.
 */

public class ShootGrunt : AbstractEnemy
{
    public GameObject enemyBullet;
    public float fireRate;

    private float currentTimer = 0f;

    public override void Jump()
    {
 
    }

    public override void Shoot()
    {
        currentTimer += Time.deltaTime;

        if (currentTimer >= fireRate)
        {
            currentTimer = 0f;
            GameObject newBullet = Instantiate (enemyBullet, transform.position, Quaternion.identity);
            Bullet bulletScript = newBullet.GetComponent<Bullet>();
            bulletScript.SetDirection((int)Mathf.Sign(player.position.x - transform.position.x));
        }
    }
}
