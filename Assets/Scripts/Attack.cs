using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject projectile; // for the fireball
    public float projectileSpeed;
    public int numberOfFireBallsRemaining;
    EnemyHealth health;
    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            numberOfFireBallsRemaining--;
            if(numberOfFireBallsRemaining > 0 && numberOfFireBallsRemaining <= 5) {
                if(numberOfFireBallsRemaining < 0) {
                    numberOfFireBallsRemaining = 0; 
                }
                Debug.Log(numberOfFireBallsRemaining);
                GameObject fireball = Instantiate(projectile, transform) as GameObject;
                Rigidbody rb = fireball.GetComponent<Rigidbody>();
                rb.velocity = transform.forward * projectileSpeed;
            }
        }
    }
}
