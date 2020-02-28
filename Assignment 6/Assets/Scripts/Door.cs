using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public enum doorType
    {
        fast,
        small,

        normal
    }

    public doorType type;
}
