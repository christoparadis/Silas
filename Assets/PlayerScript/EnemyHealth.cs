using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    public int counter;
    public GameObject DeadParticles;



    void Update() {
        if(health < 1) {
            counter = PlayerPrefs.GetInt("killCount", 0);
            counter++;
            PlayerPrefs.SetInt("killCount", counter);
            PlayerPrefs.Save();
            Instantiate(DeadParticles,transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage) {
        health -= damage;
        Debug.Log("damage taken");
    } 

    public void TakeHealthByStomp() {
        health = 0;
        Debug.Log("Stompped");
    }
}
