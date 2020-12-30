using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballAttack : MonoBehaviour
{
    // fireball attack variables
    public Transform firePosition; // where to spawn the fireball
    public GameObject projectile; // fireball
    public int count;
    public AudioSource Silas_Audio;
    public AudioClip clip;

    private void Start() {
        count = 5;    
    }
    private void OnEnable(){
        Start();
    }
  
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift)) {
            Silas_Audio.PlayOneShot(clip,1.0f);
            count--;
            Debug.Log("Pew Pew Fiar");
            GameObject Fire = Instantiate(projectile, firePosition.position, firePosition.rotation);
            Destroy(Fire, 5);
            if(count<1){
                gameObject.SetActive(false);
            }
            
        }

    }

}
