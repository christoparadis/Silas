using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace silasRedemption {
    public class Silas_AudioManager : MonoBehaviour
    {
        public AudioSource Silas_Audio;
        public AudioClip Jump;
        public AudioClip Special;

        void Update()
        {


            //Jump
            if(Input.GetKeyDown(KeyCode.Space)){
                Silas_Audio.PlayOneShot(Jump,1.0f);
            } 

            //Special
            if(Input.GetKeyDown(KeyCode.LeftShift)){
                Silas_Audio.PlayOneShot(Special,1.0f);

            } 
            
            
        }
    }
}


