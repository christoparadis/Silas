
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shop : MonoBehaviour {
    public bool hasPowerUp;
    public GameObject ShopUI;
    //public GameObject ShopTrigger;

    private void Start() {
        ShopUI.SetActive(false);
    }
    private void Update() {
        //
    }
    private void hasActivePowerUp(){
        if(PlayerPrefs.GetString("PowerUp") == null) {
            hasPowerUp = false;
        } else{
            hasPowerUp = true;
        }
    }
    
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            ShopUI.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other) {
        if(other.gameObject.tag == "Player") {
            ShopUI.SetActive(false);
        }
    }

    private void setFireBall(){
        string name = "FireBall";
        int price = 100;
        int value = PlayerPrefs.GetInt("MainScore",0);
        hasActivePowerUp();

        if( price > value ){
            return;
        } else {
            value -= price;
            PlayerPrefs.SetInt("MainScore", value);
        }   

        if (!hasPowerUp) {
            PlayerPrefs.SetString("PowerUp", name );
        } else {return;}


    }

}