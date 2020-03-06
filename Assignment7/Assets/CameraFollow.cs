using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour, ISavableObject
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private void LateUpdate() 
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = new Vector3(smoothedPosition.x, transform.position.y, smoothedPosition.z);
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
