using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Warren Guiles
 * CameraFollow.cs
 * Assignment7.
 * This script allows the camera to follow the player as it moves. 
 It also contains functionality for waiting a couple of seconds before
 moving to the player.
*/
public class CameraFollow : MonoBehaviour, ISavableObject
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private bool RoundStarted = false;

    private void Start() 
    {
        StartCoroutine(waitToSlide());
    }

    private void LateUpdate() 
    {
        if (RoundStarted)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = new Vector3(smoothedPosition.x, transform.position.y, smoothedPosition.z);
        }
    }

    private IEnumerator waitToSlide()
    {
        smoothSpeed = 0.005f;
        yield return new WaitForSeconds(5f);
        RoundStarted = true;

        yield return new WaitForSeconds(3f);
        smoothSpeed = 0.1f;
    }

    public  Transform GetTransform()
    {
        return transform;
    }

    public GameObject GetObject()
    {
        return gameObject;
    }

    public int GetLayer()
    {
        return gameObject.layer;
    }

    public Color GetSpriteColor()
    {
        return gameObject.GetComponent<SpriteRenderer>().color;
    }

}
