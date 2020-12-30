using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPasueButton : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    public static bool isGamePaused = false;
    public GameObject  cc;

    void Start()
    {
        pausePanel.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                ContinueGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    private void PauseGame()
    {
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
        isGamePaused = true;
        cc.SetActive(false);

        //Disable scripts that still work while timescale is set to 0
    }
    private void ContinueGame()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
        isGamePaused = false;
        cc.SetActive(true);
        //enable the scripts again
    }
}

