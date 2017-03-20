using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

	public GameObject explosionPrefab;
	public Audio audioObject;

	// Use this for initialization
	void Start () {
		audioObject = GameObject.Find ("Audio").GetComponent<Audio>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0.2f, 0);
		if (transform.position.y > 5) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		// add score
		GameObject.Find("Canvas").GetComponent<UIController>().addScore();
		// effect
		Instantiate (explosionPrefab, transform.position, Quaternion.identity);
		// play se
		audioObject.playSE ();

		// destroy
		Destroy (col.gameObject);
		Destroy (gameObject);
	}
}
