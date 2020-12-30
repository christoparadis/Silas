using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionScript : MonoBehaviour
{
    public float radius;
    public float power;
    public GameObject turtle;
    public GameObject silas;
    public int damage;
    public float thrust = 1.0f;
    public void TriggerAttack() {
        Debug.Log("Enter attacked");
        StartCoroutine("Explosive");
    } 

    IEnumerator Explosive()
    {
        yield return new WaitForSeconds(1f);

        Vector3 exPos = transform.position;
        Rigidbody rb = silas.GetComponent<Rigidbody>(); // get silas rigidbody
        rb.AddExplosionForce(power, exPos, radius, 5.0f);
        Destroy(turtle);
    }

    void OnCollisionEnter(Collision col) {
        if(col.gameObject.tag == "Player") {
            Debug.Log("Turtle hit");
             col.gameObject.GetComponent<Health>().AdjustHealth(damage);
        }
    }
}


