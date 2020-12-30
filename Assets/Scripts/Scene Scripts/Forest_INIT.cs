using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forest_INIT : MonoBehaviour
{
    public GameObject FireBall;
    public GameObject Health;
    public GameObject Lazer;
    public GameObject DoublePoints;
    public GameObject Teleport;

    void Start()
    {
        TransferPowerUp();
    }

    public void TransferPowerUp(){
        string PowerUp = PlayerPrefs.GetString("CurrentPowerUp");

        switch(PowerUp){
            case "FireBall":
                FireBall.SetActive(true);
                break;
            case "Health":
                Health.SetActive(true);
                break;
            case "Lazer":
                Lazer.SetActive(true);
                break;
            case "DoublePoints":
                DoublePoints.SetActive(true);
                break;
            case "Teleport":
                Teleport.SetActive(true);
                break;
            default:
                Debug.Log("No Power Ups");
                break;
        }

    }
}
