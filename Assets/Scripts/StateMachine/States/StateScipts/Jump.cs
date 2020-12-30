using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace silasRedemption {
    [CreateAssetMenu(fileName="New State", menuName = "Silas Redemption/AbilityData/Jump")]
    public class Jump : StateData
    {
        public bool canDoubleJump;
        public float JumpForce;
        public AnimationCurve Gravity;
        public AnimationCurve Pull;

        public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo) {
            CharacterControl control = characterState.GetCharacterControl(animator);
        
            animator.SetBool(TransitionParameter.DoubleJump.ToString(), false);
            control.PlayDust();
            characterState.GetCharacterControl(animator).RIGID_BODY.AddForce(Vector3.up * JumpForce);
            animator.SetBool(TransitionParameter.Grounded.ToString(), false);
            canDoubleJump = true;


        }

        public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo) {
            CharacterControl control = characterState.GetCharacterControl(animator);

            control.GravityMultiplier = Gravity.Evaluate(stateInfo.normalizedTime);
            control.PullMultiplier = Pull.Evaluate(stateInfo.normalizedTime);

            if(control.DoubleJump && canDoubleJump){
                animator.SetBool(TransitionParameter.DoubleJump.ToString(), true);
                canDoubleJump = false;
            }
        }

        public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo) {
            
        }

    }
}