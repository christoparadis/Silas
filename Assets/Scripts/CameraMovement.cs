using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform target;

    public bool X, Y, Z;

    public float XOffset, YOffset, ZOffset;

    private Vector3 lastpos = Vector3.zero;

    private void Awake()
    {
        lastpos = transform.position;
    }
    void Update()
    {
        if ((target.position - lastpos).z > 0)
        {
            transform.position = new Vector3(
            (X ? target.position.x + XOffset : transform.position.x),
            (Y ? target.position.y + YOffset : transform.position.y),
            (Z ? target.position.z + ZOffset : transform.position.z));
            lastpos = transform.position;
        }
    }
}
    //public Transform target;
    //public Vector3 offset;
    //public float smoothspeed = 5.0f;
    //private Vector3 lastpos = Vector3.zero;

    //private void Awake()
    //{
    //    lastpos = transform.position;
    //}
    //void LateUpdate()
    //{
    //    //this calculates the camerea position
    //    //transform.position = target.position + offset;
    //    //target.
    //    if ((target.position - lastpos).z > 0)
    //    {
    //        {
    //            Vector3 despos = target.position + offset;
    //            Vector3 smoothpos = Vector3.Lerp(transform.position, despos, smoothspeed * Time.deltaTime);
    //            transform.position = smoothpos;
    //            lastpos = transform.position;
    //        }

    //    }

    //}

