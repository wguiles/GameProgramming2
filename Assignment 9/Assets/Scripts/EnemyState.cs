using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface EnemyState
{
    void StartPatrol();

    void Move();

    void SpawnUnderlings();
}
