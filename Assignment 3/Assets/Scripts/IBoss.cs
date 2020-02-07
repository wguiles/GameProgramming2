using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBoss
{
    /*
	 * Warren Guiles
	 * IBoss.cs
	 * Assignment 3
	 * This is the interface for the subject class. It has the abtract methods
     to register, remove, and update nodes. It also contains a method
     that revives all nodes that have been killed by the player.

	 */

    void registerNode(IBossNode nodeToRegister);
    void removeNode(IBossNode nodeToRemove);

    void updateNode(int healthRemaining);

    void reviveAllNodes();


}
