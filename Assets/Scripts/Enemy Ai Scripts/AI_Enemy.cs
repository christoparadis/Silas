using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_Enemy : MonoBehaviour
{
    private string currentState = "IdleState";
    [SerializeField] Transform player;
    [SerializeField] Transform playershoot;
    [SerializeField] GameObject projectile;
    public float chaseRange;
    public float enemySpeed;
    public Animator animator;
    private GameObject temp;
    public float rightRotation;
    public float leftRotation;
    void Start()
    {
        temp = GameObject.Find("Silas");
        player = temp.transform;
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (currentState == "IdleState")
        {
            if (distance < chaseRange)
            {
                currentState = "ChaseState";
            }
        }
        else if (currentState == "ChaseState")
        {
            animator.SetBool("IsWalking", true);

            if (player.position.z > transform.position.z)
            {

                transform.Translate(transform.forward * enemySpeed * Time.deltaTime);
                transform.rotation = Quaternion.Euler(0, rightRotation, 0);
            }
            else
            {
                transform.Translate(-transform.forward * enemySpeed * Time.deltaTime);
                transform.rotation = Quaternion.Euler(0, leftRotation, 0);
            }
        }
    }

    public void TriggerAttack()
    {
        StartCoroutine("shoot");
    }
    IEnumerator shoot()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            GameObject proj = Instantiate(projectile, playershoot.position, playershoot.rotation);
            Destroy(proj, 5);

        }
    }
}