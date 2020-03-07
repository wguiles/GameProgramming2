using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
    * Warren Guiles
    * ISavableObject.cs
    * Assignment7
    * This is an interface for every object in the game that is able
    to be saved by the save state command. It allows method to access
    transforms gameObjects, layers, and sprites
*/
public interface ISavableObject
{
    Transform GetTransform();
    GameObject GetObject();

    int GetLayer();

    Color GetSpriteColor();
}
