using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavableObject
{
    /*
    * Warren Guiles
    * SavableObject.cs
    * Assignment7
    * The save state command keeps a list of these in order to save the
    progress of all moveable entities in the game and revert them to 
    their original positions when the player revers their save.
*/
    public GameObject savedObject;
    public Vector2 savedPosition;

    public int savedLayer;

    public Color savedSpriteColor;
}
