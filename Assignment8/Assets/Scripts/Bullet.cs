using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private int direction;
    public float bulletSpeed;

    public void SetDirection(int directionToSet)
    {
        direction = directionToSet;
    }

    private void Update() 
    {
        transform.Translate(new Vector2(direction * bulletSpeed * Time.deltaTime, 0f));
    }
}
