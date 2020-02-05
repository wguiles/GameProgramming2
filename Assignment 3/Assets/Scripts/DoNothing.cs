using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNothing : MonoBehaviour, INodeBehaviour
{
    public void attack()
    {
        Debug.Log("I'm not gonna do anything right now");
    }
}
