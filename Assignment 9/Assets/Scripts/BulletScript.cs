using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bulletSpeed;

   private void Update() 
   {
       transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
   }
}
