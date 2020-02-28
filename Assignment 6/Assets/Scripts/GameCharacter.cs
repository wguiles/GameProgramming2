using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameCharacter : MonoBehaviour
{
    public abstract void SetPosition(Vector2 newPos);

    public abstract void Die();

    public abstract void Move();

    public abstract void ActivateAbility();
}
