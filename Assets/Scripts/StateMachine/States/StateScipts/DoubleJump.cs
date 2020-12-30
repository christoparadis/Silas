using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace silasRedemption {
    [CreateAssetMenu(fileName="New State", menuName = "Silas Redemption/AbilityData/DoubleJump")]
    public class DoubleJump : StateData
    {

        public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo) {
            animator.SetBool(TransitionParameter.DoubleJump.ToString(), false);
        }

        public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo) {
        }

        public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo) {
            
        }

    }
}