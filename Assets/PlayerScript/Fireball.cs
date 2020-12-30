using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float projectileSpeed;
    private Rigidbody rb;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.right * projectileSpeed;
        
    }

    private void OnTriggerEnter(Collider col) {
        if(col.gameObject.tag == "Player"){
            return;
        }
        if(col.gameObject.tag == "Enemy") {
            // lower enemy health
            Debug.Log("Fireball hit"); 
            col.gameObject.GetComponent<EnemyHealth>().TakeDamage(damage); // reduce health of enemy
            Destroy(gameObject); // destroy the fireball
        }
    }
}
