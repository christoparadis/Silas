using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StompAttack : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if(other.tag == "Head") {
            other.gameObject.GetComponentInParent<EnemyHealth>().TakeHealthByStomp();
        }
    }
}
