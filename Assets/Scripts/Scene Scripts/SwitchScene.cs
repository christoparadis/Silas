using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SwitchScene : MonoBehaviour
{
    public Animator Transition;

    void OnTriggerEnter(Collider other) {
        Debug.Log(other.gameObject.name);
        if(other.gameObject.tag == "Player"){
            StartCoroutine("SceneAnimation");
        }
        
    }
    IEnumerator SceneAnimation(){
        Transition.SetTrigger("end");
        SceneManager.LoadScene(1);
        yield return new WaitForSeconds(1.5f);
    }
}
