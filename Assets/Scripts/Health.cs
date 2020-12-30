using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int MaxHealthPoints;
    public int CurrentHealthPoints;
    public int NumberOfHearts;
    public Image[] Hearts;
    public Sprite FullHeart;
    public Sprite EmptyHeart;
    public MeshRenderer renderer;
    public Color originalColor;
    public GameObject DeathScreen;
    public Animator Transition;


    void Start()
    {
        CurrentHealthPoints = MaxHealthPoints;
        originalColor = renderer.material.color;
    }


    private void Update()
    {
        CheckHeight();

        if (CurrentHealthPoints > NumberOfHearts)
        {
            CurrentHealthPoints = NumberOfHearts;
        }

        for (int i = 0; i < Hearts.Length; i++)
        {
            if (i < CurrentHealthPoints)
            {
                Hearts[i].sprite = FullHeart;
            }
            else
            {
                Hearts[i].sprite = EmptyHeart;
            }
            if (i < NumberOfHearts)
            {
                Hearts[i].enabled = true;
            }
            else
            {
                Hearts[i].enabled = false;
            }
        }
    }


    public void AdjustHealth(int damage)
    {

        CurrentHealthPoints -= damage;
        FlashRed();
        CheckDead();
    }
    void FlashRed()
    {
        renderer.material.color = Color.red;
        Invoke("ResetColor", 1.0f);
    }
    void ResetColor()
    {
        renderer.material.color = originalColor;
    }

    public void CheckDead()
    {
        if (CurrentHealthPoints > 0)
        {
            return;
        }
        else
        {
            //death
            Debug.Log("Ya Dead");
            RespawnOnDeath();
        }
    }

    public void CheckHeight(){
        float currentHeight = transform.position.y;
        if( currentHeight < -17.9f ) {
            AdjustHealth(10);
        }
    }

    public void setHealth()
    {
        MaxHealthPoints = 4;
        CurrentHealthPoints = 4;
        NumberOfHearts = 4;
    }

    public void RespawnOnDeath() {
        StartCoroutine("FlashDeath");
        PlayerPrefs.DeleteKey("CurrentPowerUp");
        Invoke("BackToHub",1.0f);
    }

    IEnumerator FlashDeath(){
        
        DeathScreen.SetActive(true);
        Transition.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        //play sound here
    }
    public void BackToHub(){
        Debug.Log("Send you back to the hub");
        SceneManager.LoadScene(0);
    }
}
