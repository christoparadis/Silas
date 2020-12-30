using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace silasRedemption {
    public class MobSpawner : MonoBehaviour {

        public GameObject[] enemies = new GameObject[5];

        private void Awake() {
            int index = Random.Range(0, 4);
            Instantiate(enemies[index],transform.position,transform.rotation);
        }
    }
}

