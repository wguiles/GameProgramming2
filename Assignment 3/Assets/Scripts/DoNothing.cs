using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNothing : INodeBehaviour
{

    public void attack(GameObject nodeObject)
    {
        Debug.Log("I'm not gonna do anything right now");
    }
}
