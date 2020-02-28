using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameCharacterFactory : MonoBehaviour
{
    public abstract GameObject SpawnGameCharacter(string type);
}
