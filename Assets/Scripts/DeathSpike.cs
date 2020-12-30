using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DeathSpike : MonoBehaviour {

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player"){
            Health player = other.gameObject.GetComponent<Health>();
            player.AdjustHealth(1);
        }
    }

}
