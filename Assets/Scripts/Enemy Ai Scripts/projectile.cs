using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float projectileSpeed;
    private Rigidbody rb;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = -transform.forward * projectileSpeed;

    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            return;
        }
        if (col.gameObject.tag == "Player")
        {
            // lower enemy health
            Debug.Log("silas hit");
            col.gameObject.GetComponent<Health>().AdjustHealth(damage); // reduce health of player
            Destroy(gameObject); // destroy the fireball
        }
    }
}