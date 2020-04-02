using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject Bullet;

    public Transform Muzzle;

    public float fireRate;
    private float currentTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTimer += Time.deltaTime * fireRate;

        if (Input.GetMouseButton(0) && currentTimer > 1)
        {
            currentTimer = 0;

            GameObject newBullet = Instantiate(Bullet, Muzzle.position, Quaternion.identity);
            newBullet.transform.forward = Muzzle.transform.up;
        }
    }
}
