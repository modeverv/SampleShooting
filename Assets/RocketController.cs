using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour {

	public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isOutSide ()) {
			//return;
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate (-0.1f, 0, 0);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (0.1f, 0, 0);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate (bulletPrefab, transform.position, Quaternion.identity);
		}
	}

	bool isOutSide(){
		Vector3 tmp = GameObject.Find ("rocket").transform.position;
		if(tmp.y < -4.35f || tmp.y > -4.45f){
			return true;
		}else{
			return false;
		}
	}
}
