using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISavableObject
{
    Transform GetTransform();
    GameObject GetObject();

    int GetLayer();

    Color GetSpriteColor();
}
