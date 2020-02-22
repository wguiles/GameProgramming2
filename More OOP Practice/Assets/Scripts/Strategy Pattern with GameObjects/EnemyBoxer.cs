using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPatternWithGameObjects
{
    public class EnemyBoxer : Enemy
    {
        public IAttackBehavior AttackBehavior;

        void private void Awake() 
        {
                        AttackBehavior = new AttackBite();
            SpecialAbilityBehavior = new SpecialAbilityWebSpray();

            //And we use gameObject.AddComponent<ChangeColorBlue>(); instead of new
            //to add the ChageColorBlue script/class to the EnemySpider on Awake()
            ChangeColorBehavior = gameObject.AddComponent<ChangeColorRed>();
        }

        public EnemyBoxer()
        {
            //AttackBehavior = new AttackPunch();
            SpecialAbilityBehavior = new SpecialAbilityBodySlam();
        }
        public override void Die()
        {
            Debug.Log("The boxer dies.");
            //add death animations and particle effects for boxer death here
            Destroy(gameObject);
        }
    }
}