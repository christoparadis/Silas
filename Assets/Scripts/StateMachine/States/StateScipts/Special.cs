using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace silasRedemption {
    [CreateAssetMenu(fileName="New State", menuName = "Silas Redemption/AbilityData/Special")]
    public class Special : StateData
    {

        public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo) {
            animator.SetBool(TransitionParameter.Special.ToString(), false);
        }

        public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo) {
        }

        public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo) {
            
        }

    }
}