using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthPower : MonoBehaviour
{
    public Health ht;
    public AudioSource Silas_Audio;
    public AudioClip clip;

    public void Update() {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Silas_Audio.PlayOneShot(clip,1.0f);
            ht.setHealth();
            gameObject.SetActive(false);
        }
    }
}
