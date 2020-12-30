using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiTuttleTeleport : MonoBehaviour
{
    public GameObject turtle; // turtle
    public GameObject player; // silas
    public int count = 0;
    public explosionScript ex;
    public Animator animator;

    void Start()
    {
        StartCoroutine("Explosive");
    }

    IEnumerator Explosive()
    {
        animator.SetBool("IsWalking", true);
        while(true) {
            yield return new WaitForSeconds(5f); // wait 5 seconds
            turtle.transform.position = new Vector3(player.transform.position.x, 1, player.transform.position.z);
		    //turtle.transform.position = player.transform.position; // go to player
		    Debug.Log("Player Teleported");
            count++;

            ex.TriggerAttack();

            if(turtle == null) {
                Debug.Log("breaked out");
                break;
            }    
        }

		//gameObject.SetActive(false);
    }


}
