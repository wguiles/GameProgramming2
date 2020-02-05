using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBossNode
{
    void updateBehaviour(int healthReamining);

    GameObject GetGameObject();
}
