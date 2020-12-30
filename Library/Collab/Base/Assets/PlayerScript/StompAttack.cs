using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StompAttack : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if(other.tag == "Enemy") {
            other.GetComponent<EnemyHealth>().TakeHealthByStomp();
        }
    }
}
