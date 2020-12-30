using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public AI_Enemy ai;
    void Start()
    {
        StartCoroutine("startTimer");
    }

    IEnumerator startTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f); // wait 1 seconds
            ai.TriggerAttack();
            break;
        }
    }
}
