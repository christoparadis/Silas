
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shop : MonoBehaviour {
    public bool hasPowerUp;
    public GameObject ShopUI;
    public PowerUpsController PowerUpsGUI;

    private void Start() {
        ShopUI.SetActive(false);
        PlayerPrefs.SetString("PowerUp", null);
        PlayerPrefs.Save();
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

    private bool hasActivePowerUp(){
        if(PlayerPrefs.GetString("PowerUp", null) == null) {
            return false;
        } else{
            return true;
        }
    }
    public bool hasEnoughScore(int score, int price){
        if(score > price || score==price){
            Debug.Log("Looky looky at that money");
            score -= price;
            PlayerPrefs.SetInt("MainScore", score);
            PlayerPrefs.Save();
            return true;
        }else{
            Debug.Log("You're boke, go home");
            return false;
        }
    }

    public void setPowerUp(string name, int price){
        int MainScore = PlayerPrefs.GetInt("MainScore",0);

        //Has enough Points & does not currently have a power up
        if( hasEnoughScore(MainScore, price) || !hasActivePowerUp()) {  
            PlayerPrefs.SetString("PowerUp", name );
            PlayerPrefs.Save();
            PowerUpsGUI.setPowerUpGUI(name);
        } else {
            Debug.Log("Cannot Assign Power Up");
        }
    }

/***************************************************************/

    public void setFireBall(){
        string name = "FireBall";
        int price = 100;
        setPowerUp(name, price);
    }
    public void setHealth(){
        string name = "Health";
        int price = 100;
        setPowerUp(name, price);
    }
    public void setLazer(){
        string name = "Lazer";
        int price = 850;
        setPowerUp(name, price);
    }
    public void setTeleport(){
        string name = "Teleport";
        int price = 600;
        setPowerUp(name, price);
    }
    public void setDoublePoints(){
        string name = "DoublePoints";
        int price = 1000;
        setPowerUp(name, price);
    }
}