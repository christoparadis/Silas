using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public CheckPoint2 cp;

    // Start is called before the first frame update
    void Start()
    {
        cp = GameObject.FindGameObjectWithTag("CP").GetComponent<CheckPoint2>();
    }

    void OnTriggerEnter(Collider other)
    {
        //  if (other.CompareTag("Player"))
        //  {
        Debug.Log("Trigger");
            cp.checkPoint = transform.position;
        //}
    }

}
