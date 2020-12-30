using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpdate : MonoBehaviour
{
    public AudioSource collectSound;
    public string isActive;
    public GameObject Silas;
    int value;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        if (other.gameObject.tag=="Player"){

            isActive = PlayerPrefs.GetString("DoublePoints", "false");

            value = PlayerPrefs.GetInt("MainScore", 0);
            if (isActive == "false")
            {
                collectSound.Play();
                value += 50;
                PlayerPrefs.SetInt("MainScore", value);
                Destroy(gameObject);
            }else
            {
                collectSound.Play();
                value += 100;
                PlayerPrefs.SetInt("MainScore", value);
                Destroy(gameObject);
            }
            PlayerPrefs.Save();
        }
    }
}
