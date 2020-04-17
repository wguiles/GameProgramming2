using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bulletSpeed;

    public GameObject bullet;

    void Update()
    {
        transform.Translate(new Vector2(0f, bulletSpeed * Time.deltaTime));
    }
}

