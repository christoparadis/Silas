using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HogAndFrogAttack : MonoBehaviour
{
    private string currentState = "IdleState";
    [SerializeField] Transform player;
    public float chaseRange;
    public float enemySpeed;
    public Animator animator;
    private int damage = 1;
    private GameObject temp;
    void Start() {
        temp = GameObject.Find("Silas");
        player = temp.transform;
        //player = GameObject.transform.Find("Silas");
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        //Debug.Log(distance);
        
        if(currentState == "IdleState") {
            if(distance < chaseRange) {
                currentState = "ChaseState";
            }
        }
        else if(currentState == "ChaseState") {
            animator.SetBool("IsWalking", true);
            
            if(player.position.z > transform.position.z) {
                // move right
                transform.Translate(transform.forward * enemySpeed * Time.deltaTime);
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else {
                transform.Translate(-transform.forward * enemySpeed * Time.deltaTime);
                transform.rotation = Quaternion.Euler(0, -180, 0);
            } 
        }
    }
    
    void OnCollisionEnter(Collision col) {
        if(col.gameObject.tag == "Player") {
            Debug.Log("Hit");
            col.gameObject.GetComponent<Health>().AdjustHealth(damage); // reduce health of player
        }
    }
}
