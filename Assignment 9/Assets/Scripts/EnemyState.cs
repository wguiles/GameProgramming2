using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface EnemyState
{

    void Move(GameObject Enemy);

    void Action(GameObject Enemy);

}
