using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public CheckPoint2 cp;
        void Start()
        {
            cp = GameObject.FindGameObjectWithTag("CP").GetComponent<CheckPoint2>();
        }

    void OnTriggerEnter(Collider other)
    {
        gameObject.transform.position = cp.checkPoint;
    }
}
