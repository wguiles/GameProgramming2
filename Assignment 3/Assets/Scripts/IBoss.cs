using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBoss
{
    void registerNode(IBossNode nodeToRegister);
    void removeNode(IBossNode nodeToRemove);

    void updateNode(int healthRemaining);

    void reviveAllNodes();


}
