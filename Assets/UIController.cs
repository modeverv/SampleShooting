using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

	long score = 0;
	GameObject scoreText;
	GameObject gameOverText;

	public void addScore(){
		this.score += 10;
	}

	public void gameOver(){
		this.gameOverText.GetComponent<Text> ().text = "GameOver";
	}

	// Use this for initialization
	void Start () {
		this.scoreText = GameObject.Find ("Score");
		this.gameOverText = GameObject.Find ("GameOver");
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.GetComponent<Text> ().text = "Score: " + score.ToString ("D4");
	}
}
