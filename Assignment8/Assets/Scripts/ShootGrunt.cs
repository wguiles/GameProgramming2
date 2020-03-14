using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGrunt : MonoBehaviour
{
    public float JumpRate;
    public float jumpHeight;

    private float currentTimer = 0f;

    public override void Jump()
    {
        currentTimer += Time.deltaTime;

        if (currentTimer >= JumpRate)
        {
            currentTimer = 0f;
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
        }
    }

    public override void Shoot()
    {
        
    }
}
