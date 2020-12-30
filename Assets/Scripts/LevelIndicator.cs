using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelIndicator : MonoBehaviour
{
    public GameObject levelIndex;
    void Start()
    {
        levelIndex.GetComponent<Text>().text =  SceneManager.GetActiveScene().name;
        
    }
}
