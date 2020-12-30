using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject turtle;
    public GameObject silas; 
    public float distance;
    private float currentTime = 0f;
    private float startingTime = 3f;
    public float radius;
    public float power;
    public float movSpeed;
    public float explosionSpeed;
    public bool timePassed;
    Vector3 targetPosition;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        this.GetComponent<Rigidbody>().AddForce(transform.forward * movSpeed);
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
    }

    // Update is called once per frame
    void Update()
    {
        // get the distance between silas and the turtle
        distance = Vector3.Distance(turtle.transform.position, silas.transform.position);     
        
        // if distance between them is less than 3.5 then have the enemy wait 3 seconds then have it explode
        if(distance <= 3.5) {
            currentTime -= 1 * Time.deltaTime; // set a timer for 3 seconds, will decremet.
            
            // if the current tiem is greater than 0
            if(currentTime <= 0) {
                // explode
                currentTime = 0;
            }
            else {
                Debug.Log(currentTime);
                // explode over here

            }
        } 
    }
}
