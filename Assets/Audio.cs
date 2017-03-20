using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {

	public AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.K)) {
			audioSource.PlayOneShot (audioSource.clip);
		}
	}
	
	public void playSE(){
		audioSource.PlayOneShot (audioSource.clip);
	}
}
