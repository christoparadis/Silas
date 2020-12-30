using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scoring : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;

    void  Update()
    {
        theScore = PlayerPrefs.GetInt("MainScore",0);
        scoreText.GetComponent<Text>().text = theScore.ToString();
    }
}
