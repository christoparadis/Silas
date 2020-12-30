using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeFireball : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        Debug.Log(other);
        Destroy(gameObject);
    }
}
