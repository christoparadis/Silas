using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace silasRedemption {
    [CreateAssetMenu(fileName="New State", menuName = "Silas Redemption/AbilityData/Attack")]
    public class Attack : StateData
    {
        private float timeBtwAttack;
        public float startTimeBtwAttack;
        public Transform attackPos;
        public float attackRange;
        public LayerMask whatIsEnemies;
        public int damage;
       
        public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo) {
            animator.SetBool(TransitionParameter.Attack.ToString(), false);
            if(timeBtwAttack <= 0) {
            // attack
                
                Collider[] enemiesToDamage = Physics.OverlapSphere(attackPos.position, attackRange, whatIsEnemies);
                for(int i = 0; i < enemiesToDamage.Length; i++) {
                    enemiesToDamage[i].GetComponent<EnemyHealth>().TakeDamage(damage);
                }
                
                timeBtwAttack = startTimeBtwAttack;
            } else {
                timeBtwAttack -= Time.deltaTime;
            }

        }

        public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo) {
            
        }

        public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo) {
            
        }

    }
}