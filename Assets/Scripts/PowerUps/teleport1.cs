using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport1 : MonoBehaviour
{
	public GameObject thePlayer;
    public AudioSource Silas_Audio;
    public AudioClip clip;


	void Update() { 
		if(Input.GetKeyDown(KeyCode.LeftShift)) {
			Silas_Audio.PlayOneShot(clip,1.0f);
			Debug.Log("Teleporting");
			thePlayer.transform.position = new Vector3(0, 1, transform.position.z + 7);
			Debug.Log("Player Teleported");
			gameObject.SetActive(false);
		}
	}
}
