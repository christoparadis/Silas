using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLaser : MonoBehaviour
{
    public Transform firePosition;
    public GameObject laser;
    public AudioSource Silas_Audio;
    public AudioClip clip;
    public int count;

    private void Start() {
        count = 10;    
    }

    private void OnEnable(){
        Start();
    }
  
    void Update()
    {
        // hold down left shit and shoot
        if(Input.GetKey(KeyCode.LeftShift)) {
            Silas_Audio.PlayOneShot(clip,1.0f);
            count--;
            Debug.Log("lazzzzzzzzz");
            GameObject Fire = Instantiate(laser, firePosition.position, firePosition.rotation);
            Destroy(Fire, 5); // destroy laser projectile after
            if(count<1){
                gameObject.SetActive(false);
            }
            
        }

    }
}
