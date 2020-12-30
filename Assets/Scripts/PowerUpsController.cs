using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpsController : MonoBehaviour {
    public GameObject[] PowerUps = new GameObject[5];

    public void setPowerUpGUI(string activePowerUp){
        Debug.Log("Activating:" + activePowerUp);
        for (int i = 0; i < 5; i++){
            if(PowerUps[i].name == activePowerUp){
                Debug.Log("Has Found! " + activePowerUp);
                PowerUps[i].SetActive(true);
                PlayerPrefs.SetString("CurrentPowerUp",PowerUps[i].name);
                PlayerPrefs.Save();
            }else{
                PowerUps[i].SetActive(false);
            }
            
        }

    }
    
    
}
