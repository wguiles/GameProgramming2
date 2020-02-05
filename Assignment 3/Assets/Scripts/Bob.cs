using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : MonoBehaviour, INodeBehaviour
{
    public void attack()
    {
        Debug.Log("I'm gonna bob up and down right about now");
    }
}
