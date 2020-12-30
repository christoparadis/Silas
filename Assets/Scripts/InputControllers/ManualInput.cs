using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace silasRedemption {
    public class ManualInput : MonoBehaviour {
        
        private CharacterControl characterControl;
        private void Awake() {
            characterControl = this.gameObject.GetComponent<CharacterControl>();
        }
        
        void Update()
        {
            if(VirtualInputManager.Instance.MoveRight){
                characterControl.MoveRight = true;
            }else{
                characterControl.MoveRight = false;
            }
            if(VirtualInputManager.Instance.MoveLeft){
                characterControl.MoveLeft = true;
            }else{
                characterControl.MoveLeft = false;
            }
            if(VirtualInputManager.Instance.Jump){
                characterControl.Jump = true;
            }else{
                characterControl.Jump = false;
            }
            if(VirtualInputManager.Instance.DoubleJump){
                characterControl.DoubleJump = true;
            }else{
                characterControl.DoubleJump = false;
            }
            /*if(VirtualInputManager.Instance.Attack){
                characterControl.Attack = true;
            }else{
                characterControl.Attack = false;
            }*/
             if(VirtualInputManager.Instance.Special){
                characterControl.Special = true;
            }else{
                characterControl.Special = false;
            }
            if(VirtualInputManager.Instance.Run){
                characterControl.Run = true;
            }else{
                characterControl.Run = false;
            }
            
        }
    }
}

