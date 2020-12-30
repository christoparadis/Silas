using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doublePoints : MonoBehaviour
{
    float timer;
    public static bool isDoubleActive = false;

    private void Awake() 
    {
        Debug.Log("Double Points ACTIVE");
        PlayerPrefs.SetString("DoublePoints", "true");
        PlayerPrefs.Save();
        isDoubleActive = true;

        StartCoroutine("waitTime");
    }

    IEnumerator waitTime()
    {
        yield return new WaitForSeconds(10);
        PlayerPrefs.SetString("DoublePoints", "false");
        PlayerPrefs.Save();
    }

}

