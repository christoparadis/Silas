using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace silasRedemption {
    public class KeyBoardInput : MonoBehaviour
    {

        void Update()
        {

            //Move right
            if(Input.GetKey(KeyCode.D)){
                VirtualInputManager.Instance.MoveRight = true;
            } else {
                VirtualInputManager.Instance.MoveRight = false;
            }
            //move left
            if(Input.GetKey(KeyCode.A)){
                VirtualInputManager.Instance.MoveLeft = true;
            } else {
                VirtualInputManager.Instance.MoveLeft = false;
            }

            //Run
            if(Input.GetKey(KeyCode.LeftControl)){
            VirtualInputManager.Instance.Run = true;
            } else {
                VirtualInputManager.Instance.Run = false;
            }

            //Jump
            if(Input.GetKeyDown(KeyCode.Space)){
                VirtualInputManager.Instance.Jump = true;
            } else {
                VirtualInputManager.Instance.Jump = false;
            }

            //Double Jump
            if(Input.GetKey(KeyCode.W)){
                VirtualInputManager.Instance.DoubleJump = true;
            } else {
                VirtualInputManager.Instance.DoubleJump = false;
            }

            //Attack
            if(Input.GetKey(KeyCode.Return)){
                VirtualInputManager.Instance.Attack = true;
            } else {
                VirtualInputManager.Instance.Attack = false;
            }
            if(Input.GetKeyDown(KeyCode.LeftShift)){
                VirtualInputManager.Instance.Special = true;

            } else {
                VirtualInputManager.Instance.Special = false;
            }
            
            
        }
    }
}


