using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : INodeBehaviour
{
    /*
	 * Warren Guiles
	 * Bob.cs
	 * Assignment 3
	 * This is one of the behaviours that are used by the BossNodes to dictate actions/attacks.
       This one specifically has the nodes moving away from and towards the boss in an attempt to hit the player.
	 */

    private Vector2 directionToTravel;

    private float direction = 1f;

    private bool movingOut = false;

    private float currentTimer = 0f;

    public void attack(GameObject nodeObj)
    {
        Debug.Log("I'm gonna bob up and down right about now");


        if (!movingOut)
         {
            currentTimer += Time.deltaTime;
            nodeObj.transform.Translate(nodeObj.GetComponent<BossNode>().GetBulletOriginPoint().right * Time.deltaTime * 4f * direction);
            
            if (currentTimer >= 0.4f)
            {
                movingOut = true;
            }
         }

         if (movingOut)
         {
             currentTimer -= Time.deltaTime;
             nodeObj.transform.position = Vector2.MoveTowards(nodeObj.transform.position, nodeObj.transform.parent.parent.position, Time.deltaTime * 4f);

            if (currentTimer <= 0.0f)
            {
                movingOut = false;
            }
         }

    }

    
}
