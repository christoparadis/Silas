using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class killedCount : MonoBehaviour
{
    public GameObject scoreText;
    public int enemyKilled;

    void Update()
    {
        enemyKilled = PlayerPrefs.GetInt("killCount", 0);
        scoreText.GetComponent<Text>().text = enemyKilled.ToString();
    }
}
